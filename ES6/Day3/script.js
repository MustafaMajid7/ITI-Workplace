//--------------------------------------- Task 1 (Object) ----------------------------------------------------

function Myinfo(obj) {
  let defaultParam = {
    courseName: "JS",
    courseDuration: 6,
    courseOwner: "ITI",
  };
  if (typeof obj == "object") {
    Object.assign(defaultParam, obj);
  }
  return defaultParam;
}

console.log(
  Myinfo({ courseName: "C#", name: "mostafa", courseOwner: "SMART" })
);

//--------------------------------------- Task 2 (Proxy) ----------------------------------------------------
/*
let person = {};

let personHandler = {
  get: function (obj, prop) {
    if (!(prop in obj)) throw `${prop} as property Not founded in Person`;
    return obj[prop];
  },
  set: function (obj, prop, value) {
    if (prop == "name") {
      if (!/^[a-zA-Z]{7}$/.test(value)) {
        throw "name must be length of 7 alphabetic characters";
      }
      return (obj[prop] = value);
    } else if (prop == "age") {
      if (!(value > 25 && value <= 60)) {
        throw "age must be between 25 and 60 years old";
      }
      return (obj[prop] = value);
    } else if (prop == "address") {
      if (typeof value != "string") {
        throw "address must be type of string";
      }
      return (obj[prop] = value);
    } else {
      throw `Can't assign new Property (${prop})`;
    }
  },
};

let myProxy = new Proxy(person, personHandler);

console.log((myProxy.age = 55));
console.log((myProxy.name = "mostafa"));
console.log((myProxy.address = "alex"));
*/
//----------------------------------- Task 3 (class shape) --------------------------------------------------

// import { shape, square, rectangle, circle } from "./containers.js";

// let s1 = new square(5, 6);
// let s2 = new rectangle(5, 6);
// let s3 = new circle(5);

// console.log(s2.parameter);
