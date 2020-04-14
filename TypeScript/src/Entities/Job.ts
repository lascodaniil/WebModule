import { GenericRepository } from '../Repository/GenericRepository';

export class Job{
    constructor(
        public id?:number,
        public Title?:string,
        public City?:string,
        public Contact?:string,
        public Author?:string,
        public PostDate?:Date,
        public EndDate?:Date,
    ){}
}

let jobsArray = [new Job(1,"Internship", "Chisinau", "060277321", "UTM",new Date(), new Date()),
                 new Job(2,"ProTV", "Orhei", "060277321", "UTM",new Date(), new Date()),
                 new Job(3,"TV8", "Balti", "060277321", "UTM",new Date(), new Date())]; 

var jobs = new GenericRepository<Job>();

function intertIntoArray(array : Job[]) : void {
    for (let index = 0; index < array.length; index++) {
        jobs.add(array[index]);
        console.log(array[index]);
    }
}

function DeleteFromArray(array: Job[]) : void{
    for (let index = 0; index < array.length/2; index++) {
        jobs.delete(index);
    }
}