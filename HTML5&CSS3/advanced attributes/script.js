function getmiddle() {
  document.getElementById("cont").scrollTop =
    document.getElementById("cont").scrollHeight / 2 -
    document.getElementById("cont").offsetHeight / 2;
}
function getcenter() {
  document.getElementById("cont").scrollLeft =
    document.getElementById("cont").scrollWidth / 2 -
    document.getElementById("cont").offsetWidth / 2;
}

function next() {
  if (document.getElementById("cont").scrollTop >= 900) {
    document.getElementById("next").disabled = false;
  }
}
let flag = true;
function trans() {
  if (window.scrollY >= 1650 && flag) {
    document.getElementById("translated").style.transform =
      "translateY(-400px)";
    document.getElementById("translated").style.opacity = 1;
    flag = false;
  }
  console.log(window.scrollY);
}
