
import { NzMessageService } from 'ng-zorro-antd/message';
import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { NzUploadFile } from 'ng-zorro-antd/upload';
import { HttpClient, HttpRequest, HttpResponse } from '@angular/common/http';
import { filter } from 'rxjs/operators';
import { Observable, Observer } from 'rxjs';
import { FileUploaderModel } from 'src/app/core/models/file-uploader';


function getBase64(file: File): Promise<string | ArrayBuffer | null> {
  return new Promise((resolve, reject) => {
    const reader = new FileReader();
    reader.readAsDataURL(file);
    reader.onload = () => resolve(reader.result);
    reader.onerror = error => reject(error);
  });
}

@Component({
  selector: 'app-file-uploader',
  templateUrl: './file-uploader.component.html',
  styleUrls: ['./file-uploader.component.css']
})
export class FileUploaderComponent implements OnInit {

  constructor(private msg: NzMessageService, private http: HttpClient,) { }
  ngOnInit(): void {

  }
  _currentFilesUIDs: string[] = [];
  _filterdList: NzUploadFile[] = []
  fileList: NzUploadFile[] = [
    // {
    //   uid: '-1',
    //   name: 'image.png',
    //   status: 'done',
    //   url: 'https://zos.alipayobjects.com/rmsportal/jkjgkEfvpUPVyRjUImniVslZfWPnJuuZ.png'
    // },
    // {
    //   uid: '-2',
    //   name: 'image.png',
    //   status: 'done',
    //   url: 'https://zos.alipayobjects.com/rmsportal/jkjgkEfvpUPVyRjUImniVslZfWPnJuuZ.png'
    // },
    // {
    //   uid: '-3',
    //   name: 'image.png',
    //   status: 'done',
    //   url: 'https://zos.alipayobjects.com/rmsportal/jkjgkEfvpUPVyRjUImniVslZfWPnJuuZ.png'
    // },
    // {
    //   uid: '-4',
    //   name: 'image.png',
    //   status: 'done',
    //   url: 'https://zos.alipayobjects.com/rmsportal/jkjgkEfvpUPVyRjUImniVslZfWPnJuuZ.png'
    // },
    // {
    //   uid: '-xxx',
    //   percent: 50,
    //   name: 'image.png',
    //   status: 'uploading',
    //   url: 'https://zos.alipayobjects.com/rmsportal/jkjgkEfvpUPVyRjUImniVslZfWPnJuuZ.png'
    // },
    // {
    //   uid: '-5',
    //   name: 'image.png',
    //   status: 'error'
    // }
  ];
  previewImage: string | undefined = '';
  previewVisible = false;
  uploading = false;

  handlePreview = async (file: NzUploadFile) => {
    if (!file.url && !file.preview) {
      file.preview = await getBase64(file.originFileObj!);
    }
    this.previewImage = file.url || file.preview;
    this.previewVisible = true;


  };


  handleUpload(): void {
    let fileForUpdate: any;
    let formData = new FormData();
    this.fileList.forEach((file: any) => {
      if (file.originFileObj && file.status != "done") {
        formData.append("files", file.originFileObj);
        formData.append("key", 'aaaaa');
        this.uploading = true;
        debugger;
        const req = new HttpRequest('POST', 'https://localhost:44356/api/File/UploadFiles1', formData, {
        });
        this.http
          .request(req)
          .pipe(filter(e => e instanceof HttpResponse))
          .subscribe(
            (data: any) => {
              console.log(data)
              this.uploading = false;


              data.body.forEach((line: any) => {
                //  let index = this.fileList.indexOf(file);
                file.status = "done";
                file.iconType = "";
                file.error = null;
                file.showDownload = true;
                file.thumbUrl = '';

                file.url = line.httpFilePath;
                this.fileList = [...this.fileList, ...file];
                // fileForUpdate = file;
                formData.delete('files');
              });
              console.log(this.fileList)
              $('.ant-upload-list-item-error').removeClass('ant-upload-list-item-error').addClass('new-file-prev')
              this.msg.success('upload successfully.');
            },
            (err) => {
              console.log(err)

              this.uploading = false;
              this.msg.error('upload failed.');
            }
          );



      }
    });

    console.log(fileForUpdate)
    // this.fileList = [...this.fileList, fileForUpdate];

  }

  handleUpload2(): void {
    debugger
    let fileForUpdate: any;
    let formData = new FormData();
    this.fileList.forEach((file: any) => {
      if (file.originFileObj && file.status != "done") {
        formData.append("files", file.originFileObj);
        formData.append("key", 'aaaaa');
        this.uploading = true;


      }
    });


    debugger;
    const req = new HttpRequest('POST', 'https://localhost:44356/api/File/UploadFiles1', formData, {
    });
    this.http
      .request(req)
      .pipe(filter(e => e instanceof HttpResponse))
      .subscribe(
        (data: any) => {
          console.log(data)
          this.uploading = false;


          this.fileList.map(s =>
          (
            {
              thumbUrl: '',
              error: null,
              originFileObj: null

            }
          ))

          this.fileList.forEach((line: any) => {

          });


          data.body.forEach((line: any) => {
            //  let index = this.fileList.indexOf(file);
            // file.status = "done";
            // file.iconType = "";
            // file.error = null;
            // file.showDownload = true;
            // file.thumbUrl = '';

            // file.url = line.httpFilePath;
            // this.fileList = [...this.fileList, ...file];
            // fileForUpdate = file;
            //   formData.delete('files');
          });
          console.log(this.fileList)
          $('.ant-upload-list-item-error').removeClass('ant-upload-list-item-error').addClass('new-file-prev')
          this.msg.success('upload successfully.');
        },
        (err) => {
          console.log(err)

          this.uploading = false;
          this.msg.error('upload failed.');
        }
      );



    console.log(fileForUpdate)
    // this.fileList = [...this.fileList, fileForUpdate];

  }


  handleUpload1(formData: any): void {

    formData.append("files", formData);
    formData.append("key", 'aaaaa');



    this.uploading = true;
    // You can use any AJAX library you like
    const req = new HttpRequest('POST', 'https://localhost:44356/api/File/UploadFiles1', formData, {
      // reportProgress: true
    });
    this.http
      .request(req)
      .pipe(filter(e => e instanceof HttpResponse))
      .subscribe(
        (data: any) => {
          console.log(data)
          this.uploading = false;
          // this.fileList = [];



          // data.body.forEach((line: any) => {
          //   let newFile: NzUploadFile = {
          //     name: line.name,
          //     url: line.httpFilePath,
          //     status: 'done',
          //     uid: line.httpFilePath,
          //     isImageUrl: true,
          //     showDownload: true,
          //     isUploading: false,
          //     iconType: "thumbnail",
          //     percent: 50
          //   }
          //   this._filterdList.push(newFile)
          //   this.fileList = this._filterdList;//.filter(obj => obj.status === 'done');
          // });





          console.log(this.fileList)


          $('.ant-upload-list-item-error').removeClass('ant-upload-list-item-error').addClass('new-file-prev')
          this.msg.success('upload successfully.');
        },
        (err) => {
          console.log(err)

          this.uploading = false;
          this.msg.error('upload failed.');
        }
      );




  };




  handleChange(event: any): void {
    debugger



    if (this._filterdList.find(s => s.uid == event.file.uid) == null) {
      this._filterdList.push(event.file)
      // const formData = new FormData();

      // this.fileList.forEach((file: any) => {
      //   if (file.originFileObj && file.status === "uploading") {
      //     formData.append("files", file.originFileObj);
      //     formData.append("key", 'aaaaa');
      //   }
      // });
      // this.handleUpload1(formData);

    }

    //  this.fileList = this.fileList.filter(obj => obj.uid === 'done');




    console.log(this._filterdList)





    // if (event.file.status === "uploading" && event.type === "start") {
    //   this.handleUpload();
    // }


  }

  beforeUpload = (file: NzUploadFile, _fileList: NzUploadFile[]) => {
    return new Observable((observer: Observer<boolean>) => {
      const isJpgOrPng =
        file.type === 'image/jpeg' || file.type === 'image/png';
      if (!isJpgOrPng) {
        this.msg.error('You can only upload JPG file!');
        observer.complete();
        return;
      }
      const isLt2M = file.size! / 1024 / 1024 < 2;
      if (!isLt2M) {
        this.msg.error('Image must smaller than 2MB!');
        observer.complete();
        return;
      }
      observer.next(isJpgOrPng && isLt2M);
      observer.complete();
    });
  };



  public formData = new FormData();
  ReqJson: any = {};
  _filesList: FileUploaderModel[] = [];
  uploadFiles(file: any) {

    console.log('file', file)
    file = file.target.files;
    for (let i = 0; i < file.length; i++) {
      this.formData.append("file", file[i], file[i]['name']);
      this.formData.append("files", file[i], file[i]['name']);

    }

    this.RequestUpload()

  }


  RequestUpload() {
    this.ReqJson["patientId"] = "12"
    this.ReqJson["requesterName"] = "test1"
    this.ReqJson["requestDate"] = "1/1/2019"
    this.ReqJson["location"] = "INDIA"
    this.formData.append('Info', JSON.stringify(this.ReqJson))


    const req = new HttpRequest('POST', 'https://localhost:44356/api/File/UploadFiles1', this.formData, {
    });


    this.http
      .request(req)
      .pipe(filter(e => e instanceof HttpResponse))
      .subscribe(
        (data: any) => {
          console.log(data)
          this.uploading = false;
          debugger
          this.formData.delete('files');

          this._filesList = [...this._filesList, ...data.body]
          //  this._filesList.push(data.body)
          //  data.body.forEach((line: any) => {
          //    //  let index = this.fileList.indexOf(file);
          //    file.status = "done";
          //    file.iconType = "";
          //    file.error = null;
          //    file.showDownload = true;
          //    file.thumbUrl = '';

          //    file.url = line.httpFilePath;
          //    this._filesList = [...this._filesList, ...file];
          //    // fileForUpdate = file;
          //  });
          console.log(this._filesList)
          // $('.ant-upload-list-item-error').removeClass('ant-upload-list-item-error').addClass('new-file-prev')
          this.msg.success('upload successfully.');
        },
        (err) => {
          console.log(err)

          this.uploading = false;
          this.msg.error('upload failed.');
        }
      );


    // this.http.post( '/Request', this.formData )
    //         .subscribe(( ) => {
    //         });
  }


}
