terraform {
  required_version = ">= 0.12"
  required_providers {
    yandex =  {
        source = "yandex-cloud/yandex"
        version = "0.88.0"
    }
  }
}

provider "yandex" {
  token     = var.yc_token
  cloud_id  = var.cloud_id
  folder_id = var.folder_id
  zone      = "ru-central1-a"
}

resource "yandex_container_registry_repository" "crud_app" {
    name = "crud-app"
    folder_id = var.folder_id
}

resource "yandex_compute_instance" "crud_vm" {
  name      = var.vm_name
  folder_id = var.folder_id
  zone      = var.vm_zone

  resources {
    cores  = var.vm_cores
    memory = var.vm_memory
  }

  boot_disk {
    initialize_params {
      image_id = var.vm_image_id
      size     = var.vm_disk_size
    }
  }

  network_interface {
    subnet_id = var.subnet_id
    nat       = true
  }

  metadata = {
    user-data = <<-EOT
      #cloud-config
      runcmd:
        - sudo apt update && sudo apt install -y docker.io
        - sudo systemctl enable docker --now
        - docker login cr.yandex/${var.folder_id} -u oauth --password ${var.yc_token}
        - docker run -d --name crud-app cr.yandex/${var.folder_id}/${var.docker_image}
    EOT
  }
}
