"use strict";
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (this && this.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};
Object.defineProperty(exports, "__esModule", { value: true });
var core_1 = require("@angular/core");
var employee_service_1 = require("./employee.service");
var userPreferenes_service_1 = require("./userPreferenes.service");
var EmployeeListComponent = /** @class */ (function () {
    function EmployeeListComponent(_employeeService, _userPreferencesService) {
        this._employeeService = _employeeService;
        this._userPreferencesService = _userPreferencesService;
        this.pageHeader = 'Employee Details';
        this.selectedEmployeeCountRadioButton = 'All';
        this.ststusMessage = 'Loading data. Please Wait...';
        //this.employees = this._employeeService.getEmployees(); change code to ngOnInit
    }
    Object.defineProperty(EmployeeListComponent.prototype, "colour", {
        get: function () {
            return this._userPreferencesService.colourPreference;
        },
        set: function (value) {
            this._userPreferencesService.colourPreference = value;
        },
        enumerable: true,
        configurable: true
    });
    EmployeeListComponent.prototype.ngOnInit = function () {
        var _this = this;
        this._employeeService.getEmployees().subscribe(function (employeeData) { return _this.employees = employeeData; }, function (error) {
            _this.ststusMessage = 'Problrm with the service. please try later';
            console.error(error);
        });
    };
    EmployeeListComponent.prototype.getEmployees = function () {
        this.employees = [
            { code: 'emp101', firstName: 'Ashwani', lastName: 'Kumar', gender: 'Male', age: 30 },
            { code: 'emp102', firstName: 'Jyoti', lastName: 'Kumar', gender: 'Female', age: 30 },
            { code: 'emp103', firstName: 'Atharv', lastName: 'Kumar', gender: 'Male', age: 20 },
            { code: 'emp104', firstName: 'Navya', lastName: 'Kumar', gender: 'Female', age: 20 },
            { code: 'emp105', firstName: 'Sunil', lastName: 'Kumar', gender: 'Male', age: 20 },
            { code: 'emp106', firstName: 'Laksmisha', lastName: 'Kumar', gender: 'Female', age: 20 }
        ];
    };
    EmployeeListComponent.prototype.trackByEmpCode = function (index, employee) {
        return employee.code;
    };
    EmployeeListComponent.prototype.getTotalEmployeesCount = function () {
        return this.employees.length;
    };
    EmployeeListComponent.prototype.getTotalMaleEmployeesCount = function () {
        return this.employees.filter(function (e) { return e.gender === "Male"; }).length;
    };
    EmployeeListComponent.prototype.getTotalFemaleEmployeesCount = function () {
        return this.employees.filter(function (e) { return e.gender === "Female"; }).length;
    };
    EmployeeListComponent.prototype.onEmployeeCountRadioButtonChange = function (selectedRadioButtonValue) {
        this.selectedEmployeeCountRadioButton = selectedRadioButtonValue;
    };
    EmployeeListComponent = __decorate([
        core_1.Component({
            selector: 'list-Employee',
            templateUrl: 'app/employee/employeeList.component.html',
            styleUrls: ['app/employee/employeeList.component.css'],
        }),
        __metadata("design:paramtypes", [employee_service_1.EmployeeService, userPreferenes_service_1.UserPreferencesService])
    ], EmployeeListComponent);
    return EmployeeListComponent;
}());
exports.EmployeeListComponent = EmployeeListComponent;
//# sourceMappingURL=employeeList.component.js.map