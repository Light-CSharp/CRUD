variable "yc_token" {}
variable "cloud_id" {}
variable "folder_id" {}
variable "network_id" {}
variable "subnet_id" {}
variable "docker_image" {
  description = "Название Docker-образа (crud-app:latest)"
}
variable "vm_name" {
  default = "crud-vm"
}
variable "vm_zone" {
  default = "ru-central1-a"
}
variable "vm_cores" {
  default = 2
}
variable "vm_memory" {
  default = 4
}
variable "vm_disk_size" {
  default = 20
}
variable "vm_image_id" {
  description = "ID образа Debian 13 для VM"
}
