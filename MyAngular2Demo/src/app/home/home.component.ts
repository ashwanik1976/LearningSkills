import { Component } from '@angular/core';
import { UserPreferencesService } from '../employee/userPreferenes.service';

@Component({
    template: `<h1>This is Home Page</h1>
                <div>
                    Colour Prereference: 
                    <input type='text' [(ngModel)] = "colour" [style.background] = "colour" /> 
                </div>
`,
    providers:[UserPreferencesService]
})
export class HomeComponent {

    constructor(private _userPreferencesService: UserPreferencesService) {
            }
    get colour(): string {
        return this._userPreferencesService.colourPreference;
    }
    set colour(value:string) {
        this._userPreferencesService.colourPreference = value;
    }
}
