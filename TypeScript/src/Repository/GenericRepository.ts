import { Job } from "../Entities/Job";

export class GenericRepository<T extends (Student | Angajator | Job )> {
    private items : T[] = [];
    constructor (){
    }

    getAllERecords() : T[]{
        return this.items;
    }

    add(object: T){
        this.items.push(object);
    }

    getItem(index: number): T {
        return this.items[index];
    }

    delete(index :number){
        delete this.items[index];
    }
    
    update(index : number, T){
        this.items[index] = T;
    }
}