let canvas = document.createElement("canvas");
canvas.setAttribute("id", "mycnv");

canvas.width = 1000;
canvas.height = 600;
canvas.style.display = "block";
canvas.style.margin = "30px auto";
canvas.style.border = "1px solid black";

document.body.appendChild(canvas);

let mycnv = document.getElementById("mycnv");

let context = mycnv.getContext("2d");

// context.fillStyle = "#aaa";

// context.fillRect(0, 0, mycnv.width, mycnv.height);

//draw doors in a window

/*
// context.fillStyle = "#444";

// context.fillRect(0, 0, mycnv.width, mycnv.height);

// context.fillStyle = "#777";

// context.fillRect(100, 100, 800, 600);

// context.fillStyle = "#aaa";

// context.fillRect(200, 200, 600, 600);

// context.fillStyle = "#eee";

// context.fillRect(300, 300, 400, 600);

// context.clearRect(400, 400, 200, 400);

// draw 2 rectangles intersect each other
*/
/*
// context.fillStyle = "rgba(255,0,0,0.3)";

// context.fillRect(80, 80, 200, 200);

// context.fillStyle = "rgba(0,255,0,0.3)";

// context.fillRect(120, 120, 200, 200);
*/

// draw a piece of watermelon

/*

// context.beginPath();

// context.fillStyle = "red";
// context.strokeStyle = "green";
// context.lineWidth = 10;

// context.arc(500, 250, 100, 0, Math.PI, false);

// context.fill();
// context.stroke();

// context.beginPath();
// context.fillStyle = "black";

// context.arc(530, 265, 5, 0, 2 * Math.PI, false);

// context.fill();

// context.beginPath();
// context.fillStyle = "black";

// context.arc(460, 280, 5, 0, 2 * Math.PI, false);

// context.fill();

// context.beginPath();
// context.fillStyle = "black";

// context.arc(560, 290, 5, 0, 2 * Math.PI, false);

// context.fill();

// context.beginPath();
// context.fillStyle = "black";

// context.arc(500, 280, 5, 0, 2 * Math.PI, false);

// context.fill();

*/

// draw a solid rectangle

/*
// context.strokeStyle = "black";
// context.lineWidth = 5;
// context.fillStyle = "#eee";

// context.fillRect(400, 200, 200, 200);
// context.strokeRect(420, 220, 160, 160);
*/

//draw circle

/*
// context.arc(500, 300, 200, 0, 2 * Math.PI, false);
// context.lineWidth = 3;
// context.fillStyle = "#FF0000";
// context.fill();
*/

// draw a triangle

/*
// context.strokeStyle = "red";
// context.lineWidth = 5;

// context.beginPath();
// context.moveTo(400, 200);
// context.lineTo(600, 400);
// context.lineTo(400, 400);
// context.lineTo(400, 200);
// context.lineJoin = "round";
// context.lineCap = "round";
// context.stroke();
// context.fill();
*/

// draw a smile face

/*
context.fillStyle = "yellow";

context.strokeStyle = "black";
context.strokeWidth = 3;

context.arc(500, 300, 200, 0, 2 * Math.PI, true);
context.stroke();
context.fill();

context.moveTo(420, 250);

context.beginPath();
context.fillStyle = "black";

context.arc(400, 250, 20, 0, 2 * Math.PI, true);
context.stroke();
context.fill();

context.moveTo(620, 250);

context.arc(600, 250, 20, 0, 2 * Math.PI, true);
context.stroke();
context.fill();

context.moveTo(650, 300);
context.strokeWidth = 100;
context.arc(500, 300, 150, 0, Math.PI, false);
context.stroke();

// context.arc(400, 390, 10, 0, Math.PI, false);
// context.arc(500, 440, 10, 0, Math.PI, false);
// context.arc(600, 390, 10, 0, Math.PI, false);

// context.fill();

context.beginPath();

context.moveTo(420, 220);

context.arc(400, 220, 20, 0, Math.PI, true);
context.stroke();

context.moveTo(620, 220);

context.arc(600, 220, 20, 0, Math.PI, true);
context.stroke();

*/

// draw linear gradient with colorful text
// colorstop is between 0-1

/*
// var grd = context.createLinearGradient(0, 0, canvas.width, 50);

// grd.addColorStop(0.5, "#FFD24C");
// grd.addColorStop(0.54, "#c3FDE8");
// grd.addColorStop(0.58, "#95E5E5");
// grd.addColorStop(0.62, "#FFBFBF");
// grd.addColorStop(0.64, "#FAF4B7");
// grd.addColorStop(0.68, "#EA906C");
// grd.addColorStop(0.72, "#8CC0DE");
// grd.addColorStop(0.74, "#00FFAB");

// context.fillStyle = grd;
// context.font = "40px Tahoma";
// context.fillText("Mostafa Maged", 450, 100);
*/

// draw pattern

/*
// let pattern = context.createPattern(document.getElementById("img3"), "repeat");

// context.fillStyle = pattern;

// context.fillRect(0, 0, canvas.width, canvas.height);
*/
