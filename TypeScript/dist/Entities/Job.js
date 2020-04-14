"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
const GenericRepository_1 = require("../Repository/GenericRepository");
class Job {
    constructor(id, Title, City, Contact, Author, PostDate, EndDate) {
        this.id = id;
        this.Title = Title;
        this.City = City;
        this.Contact = Contact;
        this.Author = Author;
        this.PostDate = PostDate;
        this.EndDate = EndDate;
    }
}
exports.Job = Job;
let jobsArray = [new Job(1, "Internship", "Chisinau", "060277321", "UTM", new Date(), new Date()),
    new Job(2, "ProTV", "Orhei", "060277321", "UTM", new Date(), new Date()),
    new Job(3, "TV8", "Balti", "060277321", "UTM", new Date(), new Date())];
var jobs = new GenericRepository_1.GenericRepository();
function intertIntoArray(array) {
    for (let index = 0; index < array.length; index++) {
        jobs.add(array[index]);
        console.log(array[index]);
    }
}
function DeleteFromArray(array) {
    for (let index = 0; index < array.length / 2; index++) {
        jobs.delete(index);
    }
}
