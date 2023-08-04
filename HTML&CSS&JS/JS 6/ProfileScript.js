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

function profile() {
  var username = document.getElementById("name");
  username.innerText = getCookie("name");
  username.style.color = getCookie("color");

  if (hasCookie("times")) {
    setCookie("times", Number(getCookie("times")) + 1);
  } else {
    setCookie("times", 1);
  }

  if (getCookie("gender") === "male") {
    document
      .getElementsByTagName("img")[0]
      .setAttribute("src", "./images/male.jpeg");
  } else {
    document
      .getElementsByTagName("img")[0]
      .setAttribute("src", "./images/female.jpeg");
  }
  document.getElementById("times").innerText = `${Number(
    getCookie("times")
  )} times`;
  document.getElementById("times").style.color = getCookie("color");
}
