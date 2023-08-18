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
let slider_index = 1;
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
