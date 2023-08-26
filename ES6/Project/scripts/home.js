import {
  hasCookie,
  getCookie,
  setCookie,
  getAllCookie,
  deleteCookie,
} from "../thirdParty/cookieAPI.js";

//-------------------------------------- Slider --------------------------------------

var slider_arr = [
  "/src/slider/img1.jpg",
  "/src/slider/img2.jpg",
  "/src/slider/img3.jpg",
  "/src/slider/img4.jpg",
  "/src/slider/img5.jpg",
  "/src/slider/img6.jpg",
  "/src/slider/img7.jpg",
  "/src/slider/img8.jpg",
  "/src/slider/img9.jpg",
  "/src/slider/img10.jpg",
  "/src/slider/img11.jpg",
  "/src/slider/img12.jpg",
];
var slider_index = 1;
function next() {
  slider_index %= 12;
  let slider = document.getElementById("slider");
  slider.style.background = `url(${slider_arr[slider_index++]})`;
  slider.style.backgroundSize = "75% 90%";
  slider.style.backgroundRepeat = "no-repeat";
  slider.style.backgroundPosition = "center";
}

function previous() {
  slider_index--;
  if (slider_index == -1) slider_index = 11;
  let slider = document.getElementById("slider");
  slider.style.background = `url(${slider_arr[slider_index]})`;
  slider.style.backgroundRepeat = "no-repeat";
  slider.style.backgroundSize = "75% 90%";
  slider.style.backgroundPosition = "center";
}
//-------------------------------------- Core ----------------------------------------
var items_arr = [
  {
    src: "/src/phones/img1.jpeg",
    price: 100,
    quantity: 5,
    cat: "phones",
    cart: 0,
  },
  {
    src: "/src/phones/img2.jpeg",
    price: 200,
    quantity: 4,
    cat: "phones",
    cart: 0,
  },
  {
    src: "/src/phones/img3.jpeg",
    price: 300,
    quantity: 3,
    cat: "phones",
    cart: 0,
  },
  {
    src: "/src/phones/img4.jpeg",
    price: 400,
    quantity: 2,
    cat: "phones",
    cart: 0,
  },
  {
    src: "/src/phones/img5.jpg",
    price: 500,
    quantity: 1,
    cat: "phones",
    cart: 0,
  },
  { src: "/src/laps/img1.jpeg", price: 100, quantity: 5, cat: "laps", cart: 0 },
  { src: "/src/laps/img2.jpeg", price: 300, quantity: 2, cat: "laps", cart: 0 },
  { src: "/src/laps/img3.jpeg", price: 700, quantity: 8, cat: "laps", cart: 0 },
  { src: "/src/laps/img4.jpeg", price: 500, quantity: 4, cat: "laps", cart: 0 },
  {
    src: "/src/tablets/img1.jpeg",
    price: 300,
    quantity: 2,
    cat: "tabs",
    cart: 0,
  },
  {
    src: "/src/tablets/img2.jpeg",
    price: 250,
    quantity: 5,
    cat: "tabs",
    cart: 0,
  },
  {
    src: "/src/tablets/img3.jpeg",
    price: 200,
    quantity: 10,
    cat: "tabs",
    cart: 0,
  },
  { src: "/src/pcs/img1.jpeg", price: 100, quantity: 5, cat: "pcs", cart: 0 },
  { src: "/src/pcs/img2.jpeg", price: 300, quantity: 2, cat: "pcs", cart: 0 },
  { src: "/src/pcs/img3.jpeg", price: 900, quantity: 3, cat: "pcs", cart: 0 },
  { src: "/src/pcs/img4.jpeg", price: 600, quantity: 4, cat: "pcs", cart: 0 },
  { src: "/src/pcs/img5.jpeg", price: 1200, quantity: 6, cat: "pcs", cart: 0 },
  { src: "/src/pcs/img6.jpg", price: 1500, quantity: 7, cat: "pcs", cart: 0 },
];
var cart_empty = true;
var show_car = true;
function add_new_element(index) {
  let item = document.createElement("div");
  let image = document.createElement("img");
  let addBTN = document.createElement("button");
  addBTN.addEventListener("click", function () {
    restore_quantity(index, this);
  });
  addBTN.innerText = "Remove";
  image.setAttribute("src", items_arr[index].src);
  let spanQ = document.createElement("span");
  spanQ.innerText = `Quantity : ${++items_arr[index].cart}`;
  item.appendChild(image);
  item.appendChild(spanQ);
  item.appendChild(addBTN);
  document.getElementById("shopping_cart").appendChild(item);
}
function modify_cart(index) {
  let cart_items = document.getElementById("shopping_cart").childNodes;
  for (let i = 0; i < cart_items.length; i++) {
    if (cart_items[i].firstChild.getAttribute("src") == items_arr[index].src) {
      cart_items[i].childNodes[1].innerText = `Quantity : ${++items_arr[index]
        .cart}`;
    }
  }
}
function subtract_quantity(index, that) {
  let x = document.getElementById("summation");
  let parent = that.parentNode;
  x.innerText = Number(x.innerText) + 1;
  items_arr[index].quantity = items_arr[index].quantity - 1;
  parent.childNodes[2].innerText = `Quantity ${items_arr[index].quantity} Price ${items_arr[index].price}`;
  if (items_arr[index].quantity === 0) parent.parentNode.removeChild(parent);
}
function restore_quantity(index, that) {
  deleteCookie(index);
  let div = that.parentNode;
  let quantity = parseInt(String(div.childNodes[1].innerText).indexOf(":")) + 2;
  quantity = String(div.childNodes[1].innerText).substring(quantity);
  items_arr[index].cart = 0;
  let x = document.getElementById("summation");
  x.innerText = Number(x.innerText) - quantity;
  items_arr[index].quantity += parseInt(quantity);
  div.parentNode.removeChild(div);
  if (document.getElementById("shopping_cart").innerHTML == "") {
    document.getElementById("shopping_cart").innerHTML = "Cart is empty";
    cart_empty = true;
  }
  let childs = document.getElementById("items").childNodes;
  for (let i = 0; i < childs.length; i++) {
    if (childs[i].childNodes[0].getAttribute("src") == items_arr[index].src) {
      childs[
        i
      ].childNodes[2].innerText = `Quantity ${items_arr[index].quantity} Price ${items_arr[index].price}`;
    }
  }
}
function addToCart(index, that) {
  add_to_cookies(index);
  if (cart_empty) {
    cart_empty = false;
    document.getElementById("shopping_cart").innerHTML = "";
  }
  if (!items_arr[index].cart) add_new_element(index);
  else modify_cart(index);

  subtract_quantity(index, that);
}
function show_items(that) {
  document.getElementById("items").innerHTML = "";
  let category = that.parentNode.getAttribute("id");
  for (let index = 0; index < items_arr.length; index++) {
    if (items_arr[index].quantity == 0 || category !== items_arr[index].cat)
      continue;
    let div = document.createElement("div");
    let img1 = document.createElement("img");
    let addBTN = document.createElement("button");
    let spanPQ = document.createElement("span");

    addBTN.innerText = "Add To Cart";
    spanPQ.innerText = `Quantity ${items_arr[index].quantity} Price ${items_arr[index].price}`;
    addBTN.addEventListener("click", function () {
      addToCart(index, this);
    });
    img1.setAttribute("src", items_arr[index].src);
    div.appendChild(img1);
    div.appendChild(addBTN);
    div.appendChild(spanPQ);
    document.getElementById("items").appendChild(div);
  }
}
// function show_cart() {
//   let x = document.getElementById("shopping_cart");
//   if (show_car) {
//     show_car = false;
//     x.style.display = "block";
//   } else {
//     show_car = true;
//     x.style.display = "none";
//   }
// }

function add_to_cookies(index) {
  if (hasCookie(index)) {
    let sum = parseInt(getCookie(index));
    setCookie(index, ++sum);
  } else {
    setCookie(index, 1);
  }
}
var add_events = document.querySelectorAll("span >span");
for (let index = 0; index < add_events.length; index++) {
  add_events[index].addEventListener("click", function () {
    show_items(this);
  });
}

// document
//   .getElementById("shopping_cart_icon")
//   .addEventListener("click", show_cart);

document
  .getElementById("shopping_cart_icon")
  .addEventListener("mouseout", function () {
    document.getElementById("shopping_cart").style.display = "none";
  });
document
  .getElementById("shopping_cart_icon")
  .addEventListener("mouseover", function () {
    document.getElementById("shopping_cart").style.display = "block";
  });
document
  .getElementById("shopping_cart")
  .addEventListener("mouseout", function () {
    document.getElementById("shopping_cart").style.display = "none";
  });
document
  .getElementById("shopping_cart")
  .addEventListener("mouseover", function () {
    document.getElementById("shopping_cart").style.display = "block";
  });

document.getElementById("slider").childNodes[1].addEventListener("click", next);
document
  .getElementById("slider")
  .childNodes[3].addEventListener("click", previous);

let get_cart_items = getAllCookie();

for (let i = 0; i < get_cart_items.length; i++) {
  let index = parseInt(get_cart_items[i].split("=")[0]);
  let cart_item_quantity = parseInt(get_cart_items[i].split("=")[1]);

  if (cart_empty) {
    cart_empty = false;
    document.getElementById("shopping_cart").innerHTML = "";
  }

  let x = document.getElementById("summation");
  x.innerText = Number(x.innerText) + cart_item_quantity;

  let item = document.createElement("div");
  let image = document.createElement("img");
  let addBTN = document.createElement("button");
  addBTN.addEventListener("click", function () {
    restore_quantity(index, this);
  });
  addBTN.innerText = "Remove";
  image.setAttribute("src", items_arr[index].src);
  let spanQ = document.createElement("span");
  items_arr[index].cart += cart_item_quantity;
  items_arr[index].quantity -= cart_item_quantity;
  spanQ.innerText = `Quantity : ${items_arr[index].cart}`;
  item.appendChild(image);
  item.appendChild(spanQ);
  item.appendChild(addBTN);
  document.getElementById("shopping_cart").appendChild(item);
}
