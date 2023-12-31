export { getAllCookie, hasCookie, deleteCookie, getCookie, setCookie };

function getCookie(cookieName) {
  var data = document.cookie.split("; ");
  for (var i = 0; i < data.length; i++) {
    var portion = data[i].split("=");
    if (portion[0] == cookieName) {
      return portion[1];
    }
  }
}

function setCookie(cookieName, cookieValue) {
  document.cookie = `${cookieName}=${cookieValue}`;
}

function deleteCookie(cookieName) {
  let data = document.cookie.split("; ");
  for (var i = 0; i < data.length; i++) {
    let portion = data[i].split("=");
    let lastDate = new Date();
    lastDate.setDate(lastDate.getDate() - 1);
    if (portion[0] == cookieName) {
      document.cookie = `${portion[0]}= ;expires=${lastDate}; path=/;`;
    }
  }
}

function getAllCookie() {
  return document.cookie.split("; ") == "" ? [] : document.cookie.split("; ");
}

function hasCookie(cookieName) {
  var flag = false;
  var data = document.cookie.split("; ");
  for (var i = 0; i < data.length; i++) {
    var portion = data[i].split("=");
    if (portion[0] == cookieName) {
      flag = true;
    }
  }
  return flag;
}
