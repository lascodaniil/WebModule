"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
class GenericRepository {
    constructor() {
        this.items = [];
    }
    getAllERecords() {
        return this.items;
    }
    add(object) {
        this.items.push(object);
    }
    getItem(index) {
        return this.items[index];
    }
    delete(index) {
        delete this.items[index];
    }
    update(index, T) {
        this.items[index] = T;
    }
}
exports.GenericRepository = GenericRepository;
