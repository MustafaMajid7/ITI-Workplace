/*                                            Task 1                                                    */

type stringOrNumber = string | number;

var arr:stringOrNumber [] = ["ali",30];

console.log(arr);

/*                                            Task 2                                                    */

interface IEmployee {
    id : number;
    fname:string;
    age:number;
    salary:number;
    overtime:number;
    display:()=>number;
}

class Employee implements IEmployee{
    constructor(public id:number,public fname:string, public age:number,public salary:number,public overtime:number){}
    display():number {
        return this.salary + 200*this.overtime;
    };
}

var e = new Employee (1,"mostafa",25,2000,2);

console.log(e.display())


/*                                            Task 3                                                    */

class Manager extends Employee {
    constructor(id:number,fname:string,age:number,salary:number,overtime:number,public position:string){
        super(id,fname,age,salary,overtime)
    }
}

var m = new Manager (1,"mostafa",25,2000,2,"Dean");

console.log(m.position);

