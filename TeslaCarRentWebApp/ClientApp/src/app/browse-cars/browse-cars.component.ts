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
  availableLocations = [
    "Palma Airport",
    "Palma City Center,",
    "Alcudia",
    "Manacor"
  ]
  selectedModel: string = '';
  selectedLocation: string = '';
  ngOnInit(): void {
  }

}
