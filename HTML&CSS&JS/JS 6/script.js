/*  ------------------------------------Task 1 ------------------------------------------*/
/*
var table = document.createElement("table");
table.setAttribute("id", "table1");
document.body.appendChild(table);

function getAllUsers() {
  var xhr = new XMLHttpRequest();

  xhr.open("GET", "https://jsonplaceholder.typicode.com/users");

  xhr.onload = function () {
    if (xhr.status === 200) {
      // parse the JSON response
      var data = JSON.parse(xhr.responseText);
      drawTable(data);
      console.log(xhr.status);
    } else {
      console.log("Request failed. Returned status of " + xhr.status);
    }
  };
  xhr.send();
}

function drawTable(data) {
  for (var i = 0; i < data.length; i++) {
    var tr = document.createElement("tr");
    var td1 = document.createElement("td");
    var td2 = document.createElement("td");
    var td3 = document.createElement("td");
    td1.appendChild(document.createTextNode(data[i].username));
    td2.appendChild(document.createTextNode(data[i].email));
    td3.appendChild(document.createTextNode(data[i].phone));

    tr.appendChild(td1);
    tr.appendChild(td2);
    tr.appendChild(td3);
    table.appendChild(tr);
  }
}
*/
/*  ------------------------------------Task 2 ------------------------------------------*/

// function calculate() {
//   if (arguments.length !== 2) {
//     try {
//       throw "wrong in number of arguments";
//     } catch (err) {
//       console.log(err);
//     }
//   }
// }

/*  ------------------------------------Task 3 ------------------------------------------*/

// function calculate() {
//   if (arguments.length == 0) {
//     try {
//       throw "zero arguments passed";
//     } catch (err) {
//       console.log(err);
//     }
//   } else {
//     var sum = 0;
//     for (var i = 0; i < arguments.length; i++) {
//       try {
//         if (isNaN(Number(arguments[i]))) {
//           throw `all arguments must be numbers and argument number ${
//             i + 1
//           }  isn't a number`;
//         }
//       } catch (err) {
//         console.log(err);
//         break;
//       }
//       sum += arguments[i];
//     }
//     console.log(sum);
//   }
// }

/*  ------------------------------------Task 4 ------------------------------------------*/

// function calculate() {
//   var arr = new Array();
//   for (var i = 0; i < arguments.length; i++) {
//     arr.push(arguments[i]);
//   }
//   return arr.reverse();
// }

// function calculate() {
//   var arr = new Array();
//   for (var i = arguments.length - 1; i >= 0; i--) {
//     arr.unshift(arguments[i]);
//   }
//   return arr.reverse();
// }

/*  ------------------------------------Task 5 ------------------------------------------*/

function getCookie(cookieName) {
  var data = document.cookie.split("; ");
  for (var i = 0; i < data.length; i++) {
    var portion = data[i].split("=");
    if (portion[0] === cookieName) {
      return portion[1];
    }
  }
}

function setCookie(cookieName, cookieValue) {
  document.cookie = `${cookieName}=${cookieValue}`;
}

function deleteCookie(cookieName) {
  var data = document.cookie.split("; ");
  for (var i = 0; i < data.length; i++) {
    var portion = data[i].split("=");
    var lastDate = new Date();
    lastDate.setDate(lastDate.getDate() - 1);
    if (portion[0] === cookieName) {
      document.cookie = `${portion[0]}= ;expires=${lastDate}`;
    }
  }
}

function getAllCookie() {
  return document.cookie.split("; ");
}

function hasCookie(cookieName) {
  var flag = false;
  var data = document.cookie.split("; ");
  for (var i = 0; i < data.length; i++) {
    var portion = data[i].split("=");
    if (portion[0] === cookieName) {
      flag = true;
    }
  }
  return flag;
}

function setProfile() {
  var username = document.getElementsByName("name")[0].value;
  var age = document.getElementsByName("age")[0].value;
  if (document.getElementsByName("gender")[0].checked) {
    var gender = document.getElementsByName("gender")[0].value;
  } else {
    var gender = document.getElementsByName("gender")[1].value;
  }
  var color = document.getElementsByName("color")[0].value;

  if (hasCookie("times")) {
    deleteCookie("times");
  }
  setCookie("name", username);
  setCookie("age", age);
  setCookie("gender", gender);
  setCookie("color", color);

  location.assign("./Profile.html");
}
