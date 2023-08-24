let canvas = document.createElement("canvas");
canvas.setAttribute("id", "mycnv");

canvas.width = 1000;
canvas.height = 600;
canvas.style.display = "block";
canvas.style.margin = "30px auto";
canvas.style.border = "1px solid black";
canvas.style.position = "relative";
canvas.style.top = "50px";

document.body.insertBefore(
  canvas,
  document.body.childNodes[document.body.childNodes.length - 3]
);

let mycnv = document.getElementById("mycnv");

let context = mycnv.getContext("2d");

context.fillStyle = "#aaa";

context.fillRect(0, 0, mycnv.width, mycnv.height);

context.fillStyle = "yellow";

context.strokeStyle = "black";
context.strokeWidth = 3;

context.arc(500, 300, 200, 0, 2 * Math.PI, true);
context.stroke();
context.fill();

context.moveTo(420, 250);

context.arc(400, 250, 20, 0, 2 * Math.PI, true);
context.stroke();

context.moveTo(620, 250);

context.arc(600, 250, 20, 0, 2 * Math.PI, true);
context.stroke();

context.moveTo(650, 300);

context.arc(500, 300, 150, 0, Math.PI, false);
context.stroke();

context.moveTo(420, 220);

context.arc(400, 220, 20, 0, Math.PI, true);
context.stroke();

context.moveTo(620, 220);

context.arc(600, 220, 20, 0, Math.PI, true);
context.stroke();
