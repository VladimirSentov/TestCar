import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { Car } from '../models';

@Injectable({
  providedIn: 'root'
})
export class CarService {

  apiUrl = environment.apiUrl;

  constructor(private httpClient :HttpClient) { }

getCars ():Observable<Car[]>{
 return this.httpClient.get<Car[]>(`${this.apiUrl}car`);
}

getCarById(carId: string):Observable<Car>{
  return this.httpClient.get<Car>(`${this.apiUrl}car/${carId}`);
}

deleteCar(carId: string):Observable<void>{
return this.httpClient.delete<void>(`${this.apiUrl}car/${carId}`);
}

updateCar(carId: string,car: Car):Observable<void>{
  return this.httpClient.put<void>(`${this.apiUrl}car/${carId}`, car);
  }
  
  addCar(car: Car):Observable<void>{
    return this.httpClient.post<void>(`${this.apiUrl}car`, car);
    }


}
