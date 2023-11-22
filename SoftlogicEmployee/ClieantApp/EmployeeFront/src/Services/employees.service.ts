import { Injectable } from '@angular/core';
import { environment } from 'src/environment/environment';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Employee } from 'src/Model/employee.model';

@Injectable({
  providedIn: 'root'
})
export class EmployeesService {

  baseUrl: string = environment.baseApiUrl;
  constructor(private http: HttpClient) { }

  getAllEmployee(): Observable<Employee[]>{
    return this.http.get<Employee[]>(this.baseUrl + '/api/Employee');
  }

  addEmployee(addEmployeeRequest: Employee): Observable<Employee[]>{
    addEmployeeRequest.id = '00000000-0000-0000-0000-000000000000';
    return this.http.post<Employee[]>(this.baseUrl + '/api/Employee',addEmployeeRequest);
  }
}
