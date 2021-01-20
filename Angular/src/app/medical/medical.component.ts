import { Component, OnInit } from '@angular/core';
import { BloodTest, MedicalIndices } from '../bloodTest';
import { MedicalSystemService } from '../medical-system.service';
@Component({
  selector: 'app-medical',
  templateUrl: './medical.component.html',
  styleUrls: ['./medical.component.css']
})
export class MedicalComponent implements OnInit {

  selectedValueShape = null;
  value: string;
  Symbol:string[] = ['-','+','/','*'];
  constructor(private AllDataInServer: MedicalSystemService) { }

  // displayedColumns: string[] = ['medicalID', 'platelets', 'albumin', 'date'];
  dataSource;
  result: any;

  ngOnInit(): void {
   this.getData();
  }

  Value: BloodTest = {
    Platelet: null,
    Albumin: null,
    symbol:null
  }

  getData() {
    this.AllDataInServer.GetMedicalIndices().subscribe((data:MedicalIndices[])=>{
      console.log(data);
      this.dataSource = data;
    })
  }

  dataChanged(value) {
    this.Value.symbol = value;
    console.log(this.Value.symbol);
  }

  sendDataToService() {
    console.log("SELECT1: " + this.selectedValueShape);
    this.AllDataInServer.Add(this.Value).subscribe(data=>{ 
    this.result = data;
    this.getData();
    })
  }

 
}
