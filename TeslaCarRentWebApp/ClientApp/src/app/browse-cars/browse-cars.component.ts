import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-browse-cars',
  templateUrl: './browse-cars.component.html',
  styleUrls: ['./browse-cars.component.css']
})
export class BrowseCarsComponent implements OnInit {

  constructor() { }
  availableCars = [
    "Tesla S",
    "Tesla 3",
    "Tesla X",
    "Tesla Y"
  ]
  ngOnInit(): void {
  }

}
