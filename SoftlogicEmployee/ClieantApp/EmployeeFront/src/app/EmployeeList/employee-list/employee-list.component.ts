import { Component, OnInit } from '@angular/core';
import { Employee } from 'src/Model/employee.model';
import { EmployeesService } from 'src/Services/employees.service';

@Component({
  selector: 'app-employee-list',
  templateUrl: './employee-list.component.html',
  styleUrls: ['./employee-list.component.css']
})
export class EmployeeListComponent implements OnInit {

  constructor(private _employeesService: EmployeesService){}
  employees: Employee[] = [];
  ngOnInit(): void {
    
    this._employeesService.getAllEmployee()
    .subscribe({
      next: (employees) =>{
          this.employees = employees;
          console.log(employees);
      },
      error: (response) =>{
        console.log(response);
      }
    })
    
  }

}
