import { Component, OnInit } from '@angular/core';
import { Car } from '../models';
import { CarService } from '../services/car.service';

@Component({
  selector: 'app-car',
  templateUrl: './car.component.html',
  styleUrls: ['./car.component.css']
})
export class CarComponent implements OnInit {

 cars :Car[];

  constructor(private carService :CarService) {

   }

  ngOnInit() {
    try {
    this.carService.getCars().subscribe(res=>{

      console.log(JSON.stringify(res, null, 4));

      this.cars=res;
      console.log('Cars='+this.cars);
    }, err => {
      console.log('asd ' + err.message);
    }, () => {
      console.log('completed');
    });
}catch(err){
    console.log('err ' + err);
  }
  }

}
