```js
   Upload_Image: function () {
                    var files = $("#CoverPhotoUrlFile");
                    var formData = new FormData();
                    formData.append("attachment", files[i].files[0]);

                    var sendUrl = "/ajaxPage/IES/UploadFiles.ashx?_type=iescover&IsNew=1 ";//&IsNew=1    

                    $.ajax({
                        url: sendUrl,
                        type: 'POST',
                        cache: false,
                        data: formData,
                        processData: false,
                        contentType: false,
                        dataType: "json",
                        timeout: 600000,
                        beforeSend: function () {
                            uploading = true;
                        },
                        success: function (data) {
                            if (data.files[0].thumbnail_url) {
                                $("#ImageUrl").val(data.files[0].long_url);
                                $("#ImageUrl").attr("data-new", 1);
                                Metronic.alert({
                                    type: 'success',
                                    icon: 'check',
                                    message: "上传成功，请点击提交按钮进行保存！",
                                    container: $('#detail_container'),
                                    place: 'prepend'
                                });
                            }

                            else {
                                bootbox.alert(data.files[0].error);
                            }
                            uploading = false;
                        }
                    });
                }

```
