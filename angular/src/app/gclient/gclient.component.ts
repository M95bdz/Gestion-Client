import { ListService, PagedResultDto } from '@abp/ng.core';
import { Component, OnInit, Output, EventEmitter } from '@angular/core';
import { GClientService, GClientDto } from '@proxy/gclients';
import { FormGroup, FormBuilder, Validators } from '@angular/forms'; 
import { NgbDateNativeAdapter, NgbDateAdapter } from '@ng-bootstrap/ng-bootstrap';
import { ConfirmationService, Confirmation } from '@abp/ng.theme.shared';
import { HttpClient, HttpEventType } from '@angular/common/http';
import { formatCurrency } from '@angular/common';
import { Gclients } from '@proxy';
import { ConfigService } from 'src/assets/ConfigService';
import { DomSanitizer } from '@angular/platform-browser';
//import { ConfigService } from './config.service';
//import { DomSanitizer } from '@angular/platform-browser';

@Component({
  selector: 'app-gclient',
  templateUrl: './gclient.component.html',
  styleUrls: ['./gclient.component.scss'],
  providers: [ListService, { provide: NgbDateAdapter, useClass: NgbDateNativeAdapter }],
})
export class GClientComponent implements OnInit {
  gclient = { items: [], totalCount: 0 } as PagedResultDto<GClientDto>;
  selectedGClient = {} as GClientDto;
  
  thumbnail:any;
  selectedFile: File = null;
  
  form: FormGroup;
  isModalOpen = false;
  public message: string;
  public progress: number;
  @Output() public onUploadFinished = new EventEmitter();
  path: string;
  image: any;
  
  constructor(
    //private imageService: ConfigService, 
    //private sanitizer: DomSanitizer,
    public readonly list: ListService, 
    private gclientService: GClientService,
    private fb: FormBuilder,
    private confirmation: ConfirmationService, 
    //private imageService: ConfigService, 
    private http: HttpClient) {}

  ngOnInit() {
    const gclientStreamCreator = (query) => 
    this.gclientService.getList(query);

    this.list.hookToQuery(gclientStreamCreator)
    .subscribe((response) => {
      this.gclient = response;
      
      //this.setCoverImage(this.gclient);
    });
    
  
  }

  /*getClient(){
    this.gclientService.getList.subscribe(response => {
      this.gclients = response.data;
      this.dataLoaded = true;
      this.setCoverImage(this.gclients);
    });
  }*/

  setCoverImage(gclientList){
    gclientList.forEach(item => {
      this.gclientService.get(item.gclientId).subscribe((baseImage :any)=> {
        let objectURL = baseImage.image;
        this.thumbnail = objectURL;
      })
      });
    }

  /*setCoverImg(gclientList){
    gclientList.forEach(item => {
      this.carImageService.getCarImagesById(item.carId).subscribe(response => {
        item.imagePath = "http://localhost:4200/" + response.data[0].imagePath;
      }) 
    });

  }*/

  onFileSelected(event){
    this.selectedFile = <File> event.target.files[0];
  }

  onUpload(){
    const filedata=new FormData();
    filedata.append('image', this.selectedFile ,this.selectedFile.name);
    this.http.post('https://localhost:44354/api/Values', filedata)
    .subscribe(res => {
      console.log(res);
    })
  }

  /*public uploadFile = (files) =>{
    if(files.length === 0)
      return;
    
    let fileToUpload = <File>files[0];
    const formData = new FormData();
    formData.append('file', fileToUpload, fileToUpload.name);

    this.http.post('https://localhost:44354/api/upload', formData, {reportProgress: true, observe: 'events'})
    .subscribe(event => {
      if (event.type === HttpEventType.UploadProgress)
        this.progress = Math.round(100 * event.loaded / event.total);
      else if (event.type === HttpEventType.Response) {
        this.message = 'Upload success.';
        this.onUploadFinished.emit(event.body);
      }
    });

  }*/

  createGClient() {
    this.selectedGClient = {} as GClientDto;
    this.buildForm();
    this.isModalOpen = true;
  }

  editGClient(id: string) {
    this.gclientService.get(id).subscribe((gclient) => {
      this.selectedGClient = gclient;
      this.buildForm();
      this.isModalOpen = true;
    });
  }

  delete(id: string) {
    this.confirmation.warn('::AreYouSureToDelete', '::AreYouSure').subscribe((status) => {
      if (status === Confirmation.Status.confirm) {
        this.gclientService.delete(id).subscribe(() => this.list.get());
      }
    });
  }
  pathImg ="./assets/k.jpg";
  // add buildForm method
  buildForm() {
    this.form = this.fb.group({
      nomComplet: ['', Validators.required],
      cin: ['', Validators.required],
      email: ['', Validators.email],
      dateNais: [null, Validators.required],
      num: [null, Validators.required],
      adresse: ['', Validators.required],
      pathImg : ['', Validators.required],

    });
  }

  save() {
    if (this.form.invalid) {
      return;
    }

    const request = this.selectedGClient.id
      ? this.gclientService.update(this.selectedGClient.id, this.form.value)
      : this.gclientService.create(this.form.value);

    request.subscribe(() => {
      this.isModalOpen = false;
      this.form.reset();
      this.list.get();
    });
  }
}

