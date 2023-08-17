//------------------------------------------- Task1 -----------------------------------------------

// let arr = [5, 6, 7, 8, 9, 10, 12, 15, 18, 20];
/*
let func = function () {
  let step = 0;
  return {
    next: function () {
      step++;
      console.log(`step ${step + 1}`);
      return step < arr.length
        ? { value: arr[step++], done: false }
        : { value: 0, done: true };
    },
  };
};

arr[Symbol.iterator] = func;

for (let x of arr) {
  console.log(x);
}

*/
/*
arr[Symbol.iterator] = function* () {
  for (let step in this) {
    yield `i'm in step number ${Number(step) + 1} and value equal ${
      this[step]
    }`;
  }
};

for (let element of arr) {
  console.log(element);
}
*/

// let iterableObject = {
//   name: "mostafa",
//   age: 25,
//   address: "nawa",
//   profession: "developer",
// };

// function myFunc() {
//   let step = 0;
//   return {
//     next: function () {
//       step += 2;
//       if (step <= 10) {
//         return {
//           value: step,
//           done: false,
//         };
//       } else {
//         return {
//           value: undefined,
//           done: true,
//         };
//       }
//     },
//   };
// }

// function myFunc() {
//   let keys = Object.keys(this);
//   let step = 0;
//   return {
//     next: ()=> {
//       if (keys.length > step) {
//         return {
//           value: this[keys[step++]],
//           done: false,
//         };
//       } else {
//         return {
//           value: "finished",
//           done: true,
//         };
//       }
//     },
//   };
// }

// iterableObject[Symbol.iterator] = myFunc;

// for (let item of iterableObject) {
//   console.log(item);
// }

//-------------------------------------------Task2-----------------------------------------------

// async function getData() {
//   let response = await fetch("https://jsonplaceholder.typicode.com/users");
//   let users = await response.json();

//   for (let user of users) {
//     let button = document.createElement("button");
//     button.innerText = user.name;
//     document.getElementById("buttonsSection").appendChild(button);

//     let userPosts = document.createElement("div");

//     button.addEventListener("click", async function () {
//       try {
//         var response2 = await fetch(
//           `https://jsonplaceholder.typicode.com/posts?userId=${
//             users.indexOf(user) + 1
//           }`
//         );
//         var posts = await response2.json();
//       } catch (error) {
//         console.log(error);
//       }

//       for (let post of posts) {
//         userPosts.innerHTML += `<h2>${post.title}</h2><h4>${post.body}</h4>`;
//       }
//       document.getElementById("dataSection").innerHTML = "";
//       document.getElementById("dataSection").appendChild(userPosts);
//     });
//   }
// }

// getData();
