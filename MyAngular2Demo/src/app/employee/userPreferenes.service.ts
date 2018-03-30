import { Injectable } from '@angular/core';

@Injectable()
export class UserPreferencesService {
    constructor() {
        console.log("New Instances created");
    }
    colourPreference: string = 'orange';
}