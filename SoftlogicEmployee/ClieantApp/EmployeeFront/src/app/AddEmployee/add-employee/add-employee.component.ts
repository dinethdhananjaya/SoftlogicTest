import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Employee } from 'src/Model/employee.model';
import { EmployeesService } from 'src/Services/employees.service';

@Component({
  selector: 'app-add-employee',
  templateUrl: './add-employee.component.html',
  styleUrls: ['./add-employee.component.css']
})
export class AddEmployeeComponent implements OnInit {

  addEmployeeRequest: Employee ={
    id: '',
    name: '',
    email: '',
    mobile: 0,
    epf: 0,
    address: ''
  }

  constructor(private employeesservice: EmployeesService, private router: Router){}

  ngOnInit(): void {

  }

  addEmployee(){
    this.employeesservice.addEmployee(this.addEmployeeRequest)
    .subscribe({
      next:(employee) =>{
        this.router.navigate(['']);
      }
    });
  }
}

