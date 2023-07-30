// ----------------------------------------- Task1 -----------------------------------------
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

// ----------------------------------------- Task2 -----------------------------------------

// function task2(element) {
//   if (Number(element.value) === 1) {
//     document.getElementsByClassName("ready")[0].style.borderColor = "red";
//     document.getElementsByClassName("ready")[1].style.visibility = "visible";
//   } else if (Number(element.value) === 2) {
//     document.getElementsByClassName("steady")[0].style.borderColor = "yellow";
//     document.getElementsByClassName("steady")[1].style.visibility = "visible";
//   } else if (Number(element.value) === 3) {
//     document.getElementsByClassName("go")[0].style.borderColor = "green";
//     document.getElementsByClassName("go")[1].style.visibility = "visible";
//   }
// }

// ----------------------------------------- Task3 -----------------------------------------
// var index = 1;

// function add() {
//   var name = document.getElementById("name").value;
//   var age = document.getElementById("age").value;

//   if (name.length < 4 || Number(age) < 19) {
//     if (document.getElementById("wrongMessage") === null) {
//       var myP = document.createElement("p");
//       myP.appendChild(document.createTextNode("enter valid inputs"));
//       myP.style.color = "red";
//       myP.style.textAlign = "center";
//       myP.style.fontSize = "25px";
//       myP.style.textTransform = "capitalize";
//       myP.setAttribute("id", "wrongMessage");
//       document.getElementById("content").appendChild(myP);
//     }
//   } else {
//     if (document.getElementById("wrongMessage") !== null) {
//       document.getElementById("wrongMessage").remove();
//     }
//     var table = document.getElementById("table1");
//     var tr1 = document.createElement("tr");
//     var td1 = document.createElement("td");
//     var td2 = document.createElement("td");
//     var td3 = document.createElement("td");
//     var td4 = document.createElement("td");
//     var button = document.createElement("button");
//     button.setAttribute("type", "button");
//     button.addEventListener("click", function () {
//       this.parentNode.parentNode.remove();
//     });
//     button.appendChild(document.createTextNode("Remove"));

//     td1.appendChild(
//       document.createTextNode(
//         index++
//         // String(Number(table.getElementsByTagName("tr").length))
//         // String(
//         //   isNaN(document.getElementById("table1").lastChild.firstChild.value)
//         //     ? 1
//         //     : Number(
//         //         document.getElementById("table1").lastChild.firstChild.value
//         //       ) + 1
//         // )
//       )
//     );
//     td2.appendChild(
//       document.createTextNode(document.getElementById("name").value)
//     );
//     td3.appendChild(
//       document.createTextNode(document.getElementById("age").value)
//     );
//     td4.appendChild(button);
//     tr1.appendChild(td1);
//     tr1.appendChild(td2);
//     tr1.appendChild(td3);
//     tr1.appendChild(td4);
//     table.appendChild(tr1);
//     document.getElementById("name").value = null;
//     document.getElementById("age").value = null;
//   }
// }

// ----------------------------------------- Task4 -----------------------------------------

function add() {
  var element = document.getElementById("Ename");
  var styling = document.getElementById("style");
  var text = document.getElementById("text");

  var newElement = document.createElement(element.value);
  newElement.style.backgroundColor = styling.value;
  newElement.appendChild(document.createTextNode(text.value));

  document.getElementById("container").appendChild(newElement);

  element.value = null;
  styling.value = null;
  text.value = null;
}
