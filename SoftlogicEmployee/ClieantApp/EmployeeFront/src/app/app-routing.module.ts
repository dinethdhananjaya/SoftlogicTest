import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AddEmployeeComponent } from './AddEmployee/add-employee/add-employee.component';
import { EmployeeListComponent } from './EmployeeList/employee-list/employee-list.component';

const routes: Routes = [
  {
    path: '',
    component: EmployeeListComponent
  },
  {
    path: 'employees/add',
    component: AddEmployeeComponent
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
