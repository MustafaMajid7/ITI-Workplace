export { square, shape, rectangle, circle };

class shape {
  constructor(length, height) {
    if (this.constructor == shape) throw `shape can't be instantiated`;
    this.height = height;
    this.length = length;
  }
  getLength() {
    return this.length;
  }
  setLength(length) {
    this.length = length;
  }
  getHeight() {
    return this.height;
  }
  setHeight(height) {
    this.height = height;
  }
  toString() {
    return `Lenght : ${this.length}, Height : ${this.height}`;
  }
}

class square extends shape {
  constructor(length = 0, height = 0) {
    super(length, height);
    this.area = this.area();
    this.parameter = this.parameter();
  }
  area() {
    return this.length * this.height;
  }
  parameter() {
    return this.length * 4;
  }
  toString() {
    return `Lenght : ${this.length}, Height : ${this.height}, Area : ${this.area},
    Parameter : ${this.parameter} `;
  }
}

class rectangle extends shape {
  constructor(length = 0, height = 0) {
    super(length, height);
    this.area = this.area();
    this.parameter = this.parameter();
  }
  area() {
    return this.length * this.height;
  }
  parameter() {
    return (this.length + this.height) * 2;
  }
  toString() {
    return `Lenght : ${this.length}, Height : ${this.height}, Area : ${this.area},
      Parameter : ${this.parameter} `;
  }
}

class circle extends shape {
  constructor(radius) {
    super();
    this.radius = radius;
    this.area = this.area();
    this.parameter = this.parameter();
  }
  area() {
    return Math.PI * Math.pow(this.radius, 2);
  }
  parameter() {
    return Math.PI * this.radius * 2;
  }
  toString() {
    return `Radius : ${this.radius}, Area : ${this.area}, Parameter : ${this.parameter} `;
  }
}
