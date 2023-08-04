// ---------------------------------------Task 1 --------------------------------------
// var colors = ["red", "yellow", "green"];
// var texts = ["Ready", "Steady", "Go"];
// var index = 0;
// setInterval(function () {
//   document.getElementById(colors[0]).style.borderColor = "grey";
//   document.getElementById(colors[1]).style.borderColor = "grey";
//   document.getElementById(colors[2]).style.borderColor = "grey";
//   if (index === 0) {
//     document.getElementById(colors[0]).style.borderColor = colors[0];
//     document.getElementById("text").innerText = texts[0];
//     document.getElementById("text").style.color = colors[0];
//     index++;
//   } else if (index === 1) {
//     document.getElementById(colors[1]).style.borderColor = colors[1];
//     document.getElementById("text").innerText = texts[1];
//     document.getElementById("text").style.color = colors[1];
//     index++;
//   } else {
//     document.getElementById(colors[2]).style.borderColor = colors[2];
//     document.getElementById("text").innerText = texts[2];
//     document.getElementById("text").style.color = colors[2];
//     index++;
//   }
//   index = index % 3;
// }, 1000);

/* ---------------------------------------Task 2 --------------------------------------*/

// document.getElementById("form").addEventListener("submit", function (e) {
//   e.preventDefault();
//   document.getElementById("nots").innerHTML = "";
//   if (!document.getElementsByName("username")[0].value) {
//     var span = document.createElement("span");
//     var text = document.createTextNode("- Name is required");
//     span.appendChild(text);
//     document.getElementById("nots").appendChild(span);
//   }
//   if (
//     !/.{3,15}@[A-Za-z]{3,10}(\.[A-Za-z]{2,5})$/.test(
//       document.getElementsByName("email")[0].value
//     )
//   ) {
//     var span = document.createElement("span");
//     var text = document.createTextNode("- Email isn't valid");
//     span.appendChild(text);
//     document.getElementById("nots").appendChild(span);
//   }
//   if (!/[a-zA-Z]{8,}/.test(document.getElementsByName("pass")[0].value)) {
//     var span = document.createElement("span");
//     var text = document.createTextNode(
//       "- Password must be at least 8 characters"
//     );
//     span.appendChild(text);
//     document.getElementById("nots").appendChild(span);
//   }
//   if (
//     !document.getElementsByName("gender")[0].checked &&
//     !document.getElementsByName("gender")[1].checked
//   ) {
//     var span = document.createElement("span");
//     var text = document.createTextNode("- Gender must be assigned");
//     span.appendChild(text);
//     document.getElementById("nots").appendChild(span);
//   }
//   if (
//     Number(document.getElementsByName("sports")[0].checked) +
//       Number(document.getElementsByName("sports")[1].checked) +
//       Number(document.getElementsByName("sports")[2].checked) <
//     2
//   ) {
//     var span = document.createElement("span");
//     var text = document.createTextNode("- 2 sports at least must be assigned");
//     span.appendChild(text);
//     document.getElementById("nots").appendChild(span);
//   }
//   if (!/^[A-Za-z]/.test(document.getElementsByName("country")[0].value)) {
//     var span = document.createElement("span");
//     var text = document.createTextNode("- country must be selected");
//     span.appendChild(text);
//     document.getElementById("nots").appendChild(span);
//   }
// });

/* ---------------------------------------Task 3 --------------------------------------*/

// var index = 1,
//   previous = 0;
// var interval;
// document.getElementById("marbles").addEventListener("mouseover", function () {
//   clearInterval(interval);
// });
// document.getElementById("marbles").addEventListener("mouseout", function () {
//   interval = setInterval(function () {
//     document.getElementsByClassName("marble")[previous].style.borderColor =
//       "black";
//     document.getElementsByClassName("marble")[index].style.borderColor = "grey";
//     previous = index;
//     index = ++index % 5;
//   }, 1000);
// });

// document.getElementById("marbles").addEventListener(
//   "mouseout",
//   function () {
//     console.log("event happens!");
//   },
//   1000
// );

/* ---------------------------------------Task 4 --------------------------------------*/

// var newWindow = open("", "", "width=100,height=100");
// var interval,
//   flag = true;

// function stop() {
//   clearInterval(interval);
// }

// function run() {
//   if (flag) {
//     forwarding();
//   } else {
//     returning();
//   }
// }
// function forwarding() {
//   interval = setInterval(function () {
//     if (newWindow.screenY === 550) {
//       flag = false;
//       clearInterval(interval);
//       returning();
//     }
//     newWindow.moveBy(10, 10);
//   }, 30);
// }

// function returning() {
//   interval = setInterval(function () {
//     if (newWindow.screenY === 0) {
//       flag = true;
//       clearInterval(interval);
//       forwarding();
//     }
//     newWindow.moveBy(-10, -10);
//   }, 30);
// }

// forwarding();

/* ---------------------------------------Task 5 --------------------------------------*/

// function showmessage() {
//   var dataArr =
//     "Lorem ipsum dolor sit, amet consectetur adipisicing elit." +
//     "A cupiditate nihil itaque veniam accusamus deserunt non quod illum aut natus enim," +
//     " nisi inventore sapiente est fugiat odit similique ullam architecto?";

//   var newWindow = window.open("", "", "width=600,height=300");
//   var newdiv = newWindow.document.createElement("div");
//   newWindow.document.body.appendChild(newdiv);
//   var index = 0;
//   var interval = setInterval(function () {
//     if (index === dataArr.length) {
//       clearInterval(interval);
//     } else {
//       newdiv.innerText += dataArr[index++];
//     }
//   }, 50);
// }

// ----------------------------------------- Task6 -----------------------------------------
/*
// var flag;
// var arr = [
//   "./images/pic1.jpeg",
//   "./images/pic2.jpeg",
//   "./images/pic3.jpeg",
//   "./images/pic4.jpeg",
// ];

// var i = 0;
// function play() {
//   flag = true;
//   playing();
// }
// function playing() {
//   if (flag === true) {
//     i++;
//     i = i % 4;
//     document.getElementById("images").src = arr[i];
//     setTimeout(playing, 2000);
//   }
// }
// function stop() {
//   flag = false;
// }

// function styling(element) {
//   element.style.backgroundColor = "black";
// }

// function restore(element) {
//   if (element.innerText === "Play") {
//     element.style.backgroundColor = "green";
//   } else {
//     element.style.backgroundColor = "red";
//   }
// }
*/
