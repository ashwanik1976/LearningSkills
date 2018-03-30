import { Injectable } from '@angular/core';
import { IEmployee } from './employee';
import { Http,Response } from '@angular/http';
import { Observable } from 'rxjs/Observable';
import 'rxjs/add/operator/map';
import 'rxjs/add/operator/catch';
import 'rxjs/add/observable/throw';

@Injectable()
export class EmployeeService  {

    constructor(private _http: Http) {
    }
     getEmployees(): Observable<IEmployee[]> {
        //return [
        //    { code: 'emp 101', firstName: 'Ashwani', lastName: 'Kumar', gender: 'Male', age: 20 },
        //    { code: 'emp 102', firstName: 'Jyoti', lastName: 'Kumar', gender: 'Female', age: 20 },
        //    { code: 'emp 103', firstName: 'Sunil', lastName: 'Kumar', gender: 'Male', age: 20 },
        //    { code: 'emp 104', firstName: 'Manisha', lastName: 'Kumar', gender: 'Female', age: 20 },
        //]; code has been oved to web api
         return this._http.get("http://localhost:63510/api/employees").map((response: Response) => <IEmployee[]>response.json())
             .catch(this.handleError);
    }
    getEmployeeByCode(empCode: string): Observable<IEmployee> {
        return this._http.get("http://localhost:63510/api/employees/" + empCode).map((response: Response) => <IEmployee>response.json())
            .catch(this.handleError);
    }
    handleError(error : Response) {
        console.error(error);
        return Observable.throw(error);
    }
}