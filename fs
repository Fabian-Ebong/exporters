
---
####################### copy FileSplitter location Utility ############
- name: Download FileSplitter_Location_Utilities 
  win_command: "aws s3 cp --recursive {{ s3_filesplitter_path }} {{ dependency_dir }}/{{  filesplitter_directory }}"

#Inital Directory to put dependency
dependency_dir: "C:\\Temp"

#S3 bucket where corecard dependencies are pulled
dependency_bucket: "{{ s3_dependency_bucket }}/corecard/Package"

# FileSplitter_Location_Utilities
filesplitter_directory: "FileSplitter_Location_Utilities/"
s3_filesplitter_path : "{{ dependency_bucket }}/{{ filesplitter_directory }}"


s3_dependency_bucket: "s3://gs-dev-use1-cookie-sftp-transfer-data/ccbinary"


build	12-Dec-2020 00:22:56	1607732576,,ui,message,    amazon-ebs: fatal: [10.207.40.18]: FAILED! => {"changed": true%!(PACKER_COMMA) "cmd": "aws s3 cp s3://gs-dev-use1-cookie-sftp-transfer-data/ccbinary/corecard/Package/FileSplitter_Location_Utilities/ FileSplitter_Location_Utilities/\\filesplitter.zip"%!(PACKER_COMMA) "delta": "0:00:01.953263"%!(PACKER_COMMA) "end": "2020-12-12 12:22:56.596527"%!(PACKER_COMMA) "msg": "non-zero return code"%!(PACKER_COMMA) "rc": 1%!(PACKER_COMMA) "start": "2020-12-12 12:22:54.643263"%!(PACKER_COMMA) "stderr": "fatal error: An error occurred (404) when calling the HeadObject operation: Key \"ccbinary/corecard/Package/FileSplitter_Location_Utilities/\" does not exist\r\n"%!(PACKER_COMMA) "stderr_lines": ["fatal error: An error occurred (404) when calling the HeadObject operation: Key \"ccbinary/corecard/Package/FileSplitter_Location_Utilities/\" does not exist"]%!(PACKER_COMMA) "stdout": ""%!(PACKER_COMMA) "stdout_lines": []}
