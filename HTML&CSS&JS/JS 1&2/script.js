// ----------------------------------Task 1 ---------------------------------------------

// for(i=1;i<=6;i++){
//     var input = prompt("enter header no "+i);
//     var x = document.getElementById("task");
//     x.innerHTML +=("<h"+i+">" + input + "</h"+i+"><br>");
// }

// ----------------------------------Task 2 ---------------------------------------------
// var sum = 0;

// while (sum <= 100) {
//   var input1 = prompt("enter a numeric value");
//   if (isNaN(input1) || input1 === "") {
//     console.log("enter a valid numeric value");
//   } else if (parseInt(input1) === 0) {
//     break;
//   } else {
//     sum += parseInt(input1);
//   }
// }

// var x = document.getElementById("task");
// x.innerHTML += "<h1>" + sum + "</h1>";

// ----------------------------------Task 3 ---------------------------------------------

// var input1 = prompt("enter target string");
// var count = 0;
// if (typeof input1 === "string" || input1 instanceof String)
//   for (var i = 0; i < input1.length; i++) {
//     if (input1[i] == "e") {
//       count++;
//     }
//   }
// else {
//   count = "input type isn't string";
// }
// var x = document.getElementById("task");
// x.innerHTML += "<h1>" + count + "</h1>";

// ----------------------------------Task 4 ---------------------------------------------

// var input1 = prompt("enter target string");
// var flag = true;
// if (typeof input1 === "string" || input1 instanceof String)
//   for (var i = 0; i < input1.length / 2; i++) {
//     if (input1[i] != input1[input1.length - i - 1]) {
//       flag = false;
//     }
//   }
// else {
//   count = "input type isn't string";
// }
// var x = document.getElementById("task");
// if (flag) {
//   x.innerHTML += "<h1>" + "string is Palindrome " + "</h1>";
// } else {
//   x.innerHTML += "<h1>" + "string isn't Palindrome " + "</h1>";
// }

// ----------------------------------Task 5 ---------------------------------------------

// var input1 = prompt("enter your favourite color");

// switch (input1) {
//   case "red":
//     document.getElementById("body").style.color = "red";
//     break;
//   case "blue":
//     document.getElementById("body").style.color = "blue";
//     break;
//   case "green":
//     document.getElementById("body").style.color = "green";
//     break;
// }

// var date = new Date();
// date = `${date.getDate()} : ${date.getMonth() + 1} : ${date.getFullYear()}`;

// document.getElementById("date").innerHTML += date;

// var input1 = prompt("enter your Name");

// if (/[^A-Za-z]/.test(input1) || input1.length <= 3 || input1 == "") {
//   var x = document.getElementById("name");
//   x.innerHTML += " <strong>" + "notValid name" + "</strong>";
// } else {
//   var x = document.getElementById("name");
//   x.innerHTML += " <strong>" + input1 + "</strong>";
// }

// var input1 = prompt("enter your phone");

// if (/[0-9]{8}/.test(input1) && input1.length == 8) {
//   var x = document.getElementById("phone");
//   x.innerHTML += " <strong>" + input1 + "</strong>";
// } else {
//   var x = document.getElementById("phone");
//   x.innerHTML += " <strong>" + "notValid phone" + "</strong>";
// }

// var input1 = prompt("enter your mobile");

// if (/^(010|011|012)[0-9]{8}/.test(input1)) {
//   var x = document.getElementById("mobile");
//   x.innerHTML += " <strong>" + input1 + "</strong>";
// } else {
//   var x = document.getElementById("mobile");
//   x.innerHTML += " <strong>" + "notValid mobile" + "</strong>";
// }

// var input1 = prompt("enter your email");

// if (/.{3,15}@[A-Za-z]{3,10}(\.[A-Za-z]{2,5})$/.test(input1)) {
//   var x = document.getElementById("email");
//   x.innerHTML += " <strong>" + input1 + "</strong>";
// } else {
//   var x = document.getElementById("email");
//   x.innerHTML += " <strong>" + "notValid email" + "</strong>";
// }

// ----------------------------------Task 6 ---------------------------------------------

// var arr = new Array(3);
// for (var i = 0; i < arr.length; i++) {
//   arr[i] = prompt("enter value number " + Number(i + 1));
// }

// function summation(input1) {
//   return Number(input1[0]) + Number(input1[1]) + Number(input1[2]);
// }
// function multiplication(input1) {
//   return input1[0] * input1[1] * input1[2];
// }
// function division(input1) {
//   return input1[0] / input1[1] / input1[2];
// }
// var sum = "",
//   mul = "",
//   div = "";
// for (var i = 0; i < arr.length; i++) {
//   sum += arr[i] + "+";
//   if (i == arr.length - 1) {
//     sum += " = " + summation(arr);
//   }
// }

// for (var i = 0; i < arr.length; i++) {
//   mul += arr[i] + "*";
//   if (i == arr.length - 1) {
//     mul += " = " + multiplication(arr);
//   }
// }
// for (var i = 0; i < arr.length; i++) {
//   div += arr[i] + "/";
//   if (i == arr.length - 1) {
//     div += " = " + division(arr);
//   }
// }

// document.getElementById("sum").innerHTML += sum;
// document.getElementById("mul").innerHTML += mul;
// document.getElementById("div").innerHTML += div;

// ----------------------------------Task 7 ---------------------------------------------

// var arr = new Array(5);
// for (var i = 0; i < arr.length; i++) {
//   arr[i] = prompt("enter value number " + Number(i + 1));
// }

// document.getElementById("phase1").innerHTML += arr.slice().toString();
// document.getElementById("phase2").innerHTML += arr.sort().slice().toString();
// document.getElementById("phase3").innerHTML += arr.reverse().slice().toString();

// ----------------------------------Task 8 ---------------------------------------------

// var input1 = Number(prompt("what is the value of your circle radius"));

// alert("total area of the circle is " + Math.PI * input1 * input1);

// var input1 = Number(
//   prompt("what is the value you want to calculate square root")
// );

// alert("square root of " + input1 + " is " + Math.sqrt(input1));

// var input1 = Number(
//   prompt("what is the angle you want to calculate its cosine")
// );

// alert("cos " + input1 + " is " + Math.cos((input1 * Math.PI) / 180));

// ----------------------------------Task 9 ---------------------------------------------

// var input1 = Number(prompt("what is the number"));

// if (input1 % 3 == 0 && input1 % 5 == 0) alert("fizz buzz");
// else if (input1 % 3 == 0) alert("fizz ");
// else if (input1 % 5 == 0) alert(" buzz");
// else alert("None");

// ----------------------------------Task 10 ---------------------------------------------

// var input1 = prompt("enter a sentence");
// var input2 = prompt("enter a character that target to be searched");

// var arr = new Array();
// var i = 0;
// while (input1.indexOf(input2, i) !== -1) {
//   arr.push(input1.indexOf(input2, i));
//   i += input1.indexOf(input2, i) + 1;
// }

// alert(arr.slice().toString());

// ----------------------------------Task 11 ---------------------------------------------

var input1 = String(prompt("do you fly?"));

if (input1.toLowerCase() === "yes") {
  input1 = String(prompt("are you Wild?"));
  if (input1.toLowerCase() === "yes") {
    document.getElementById("task11").innerHTML =
      '<img src="./images/eagle.png">';
  } else {
    document.getElementById("task11").innerHTML =
      '<img src="./images/parrot.png">';
  }
} else {
  input1 = String(prompt("do you live under sea?"));
  if (input1 === "yes") {
    input1 = String(prompt("are you wild?"));
    if (input1 === "yes")
      document.getElementById("task11").innerHTML =
        '<img src="./images/shark.png">';
    else
      document.getElementById("task11").innerHTML =
        '<img src="./images/dolphin.png">';
  } else {
    input1 = String(prompt("are you wild?"));
    if (input1 === "yes")
      document.getElementById("task11").innerHTML =
        '<img src="./images/lion.png">';
    else
      document.getElementById("task11").innerHTML =
        '<img src="./images/cat.png">';
  }
}
