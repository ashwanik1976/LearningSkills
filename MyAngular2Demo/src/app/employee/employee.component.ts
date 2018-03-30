import { Component, OnInit } from '@angular/core';
import { IEmployee } from './employee';
import { ActivatedRoute, Router } from '@angular/router';
import { EmployeeService } from './employee.service'


@Component({
    selector: 'my-Employee',
    templateUrl: 'app/employee/employee.component.html',
    styleUrls: ['app/employee/employee.component.css'],
})
export class EmployeeComponent implements OnInit{
    employee: IEmployee;
    statusMessage: string='Loading Please wait...';
    constructor(private _employeeService: EmployeeService,
                private _activatedRoute: ActivatedRoute,
                private _router: Router) {
    }
    onBackButtonClick():void {
        this._router.navigate(['/employees']);
    }
    ngOnInit() {
         let empCode: string = this._activatedRoute.snapshot.params['code'];


        this._employeeService.getEmployeeByCode(empCode).subscribe((employeeData) => {
            if (employeeData != null) {
                this.employee = employeeData;
            }
            else {
                this.statusMessage = 'Probem with the service Parameter';
            }
        },
            (error) => {
                this.statusMessage = 'Error with service side';
                console.log(error);
            });
     }
}