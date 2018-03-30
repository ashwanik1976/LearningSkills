import { NgModule } from '@angular/core';
import { Component, OnInit, EventEmitter, Input, Output } from '@angular/core';
import { IEmployee } from './employee';
import { EmployeeService } from './employee.service';
import { UserPreferencesService } from './userPreferenes.service';

@Component({
    selector: 'list-Employee',
    templateUrl: 'app/employee/employeeList.component.html',
    styleUrls: ['app/employee/employeeList.component.css'],
})
export class EmployeeListComponent implements OnInit {
    pageHeader: string = 'Employee Details';

    employees: IEmployee[];
    selectedEmployeeCountRadioButton: string = 'All';
    ststusMessage: string = 'Loading data. Please Wait...';
    constructor(private _employeeService: EmployeeService, private _userPreferencesService: UserPreferencesService) {
        //this.employees = this._employeeService.getEmployees(); change code to ngOnInit
    }
    get colour(): string {
        return this._userPreferencesService.colourPreference;
    }
    set colour(value: string) {
        this._userPreferencesService.colourPreference = value;
    }
    ngOnInit() {
        this._employeeService.getEmployees().subscribe(employeeData => this.employees = employeeData,
            error => {
            this.ststusMessage = 'Problrm with the service. please try later';
                console.error(error);
            });
    }


    getEmployees(): void {

        this.employees = [
            { code: 'emp101', firstName: 'Ashwani', lastName: 'Kumar', gender: 'Male', age: 30 },
            { code: 'emp102', firstName: 'Jyoti', lastName: 'Kumar', gender: 'Female', age: 30 },
            { code: 'emp103', firstName: 'Atharv', lastName: 'Kumar', gender: 'Male', age: 20 },
            { code: 'emp104', firstName: 'Navya', lastName: 'Kumar', gender: 'Female', age: 20 },
            { code: 'emp105', firstName: 'Sunil', lastName: 'Kumar', gender: 'Male', age: 20 },
            { code: 'emp106', firstName: 'Laksmisha', lastName: 'Kumar', gender: 'Female', age: 20 }
        ];
    }


    trackByEmpCode(index: number, employee: any): string {
        return employee.code;
    }
    getTotalEmployeesCount(): number {
        return this.employees.length;
    }
    getTotalMaleEmployeesCount(): number {
        return this.employees.filter(e => e.gender === "Male").length;
    }
    getTotalFemaleEmployeesCount(): number {
        return this.employees.filter(e => e.gender === "Female").length;
    }
    onEmployeeCountRadioButtonChange(selectedRadioButtonValue: string): void {
        this.selectedEmployeeCountRadioButton = selectedRadioButtonValue;
    }
}