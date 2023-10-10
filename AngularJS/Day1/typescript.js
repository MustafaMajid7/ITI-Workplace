/*                                            Task 1                                                    */
var __extends = (this && this.__extends) || (function () {
    var extendStatics = function (d, b) {
        extendStatics = Object.setPrototypeOf ||
            ({ __proto__: [] } instanceof Array && function (d, b) { d.__proto__ = b; }) ||
            function (d, b) { for (var p in b) if (Object.prototype.hasOwnProperty.call(b, p)) d[p] = b[p]; };
        return extendStatics(d, b);
    };
    return function (d, b) {
        if (typeof b !== "function" && b !== null)
            throw new TypeError("Class extends value " + String(b) + " is not a constructor or null");
        extendStatics(d, b);
        function __() { this.constructor = d; }
        d.prototype = b === null ? Object.create(b) : (__.prototype = b.prototype, new __());
    };
})();
var arr = ["ali", 30];
console.log(arr);
var Employee = /** @class */ (function () {
    function Employee(id, fname, age, salary, overtime) {
        this.id = id;
        this.fname = fname;
        this.age = age;
        this.salary = salary;
        this.overtime = overtime;
    }
    Employee.prototype.display = function () {
        return this.salary + 200 * this.overtime;
    };
    ;
    return Employee;
}());
var e = new Employee(1, "mostafa", 25, 2000, 2);
console.log(e.display());
/*                                            Task 3                                                    */
var Manager = /** @class */ (function (_super) {
    __extends(Manager, _super);
    function Manager(id, fname, age, salary, overtime, position) {
        var _this = _super.call(this, id, fname, age, salary, overtime) || this;
        _this.position = position;
        return _this;
    }
    return Manager;
}(Employee));
var m = new Manager(1, "mostafa", 25, 2000, 2, "Dean");
console.log(m.position);
