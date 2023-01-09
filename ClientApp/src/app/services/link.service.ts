import { Injectable } from '@angular/core';
import { BehaviorSubject } from 'rxjs';

@Injectable({
  providedIn: 'root'
})

export class LinkService {

  private selectedAssignmentViaButton = new BehaviorSubject<number>(0);
  private selectedCourseViaButton = new BehaviorSubject<string>('');

  emitAssignmentEvent(assignmentName: number){
    console.log("emit", assignmentName)
    this.selectedAssignmentViaButton.next(assignmentName)
  }

  assignmentEventListner(){
    console.log("return to service")
    return this.selectedAssignmentViaButton.asObservable();
  } 

  
/*
  emitCourseEvent(courseName: string){
    console.log("emit", courseName)
    this.selectedAssignmentViaButton.next(courseName)
  }

  courseEventListner(){
    console.log("return to service")
    return this.selectedCourseViaButton.asObservable();
  } */
  constructor() { }

}
