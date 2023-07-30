// --------------------------------Task1--------------------------------

// function taskHandler() {
//   var tsk = new Array();
//   var temp = document.getElementsByName("task1")[0].value.split(" ");
//   for (var i = 0; i < temp.length; i++) {
//     tsk.push(Number(temp[i]));
//   }
//   tsk.sort(function (a, b) {
//     if (a > b) return 1;
//     if (a < b) return -1;
//     return 0;
//   });
//   tsk.pop();
//   tsk.shift();

//   document.getElementById("task1").innerHTML =
//     "the 2nd largest number is <span style='color: brown;'> " +
//     tsk.pop() +
//     " </span>";
//   document.getElementById("task1").innerHTML +=
//     "the 2nd lowest number is " +
//     "<span style='color: brown;'> " +
//     tsk.shift() +
//     " </span>";
// }

// --------------------------------Task2--------------------------------

// function taskHandler() {
//   var tsk = String(document.getElementsByName("task2")[0].value);
//   if (!tsk || Number(tsk)) {
//     document.getElementById("task2").innerText =
//       "there is no text to be transformed";
//   } else {
//     var arr = tsk.split(" ");
//     for (var i = 0; i < arr.length; i++) {
//       var temp = arr[i].split("");
//       temp[0] = temp[0].toUpperCase();
//       arr[i] = temp.join("");
//     }
//     document.getElementById("task2").innerText = arr.join(" ");
//   }
// }
