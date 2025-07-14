FROM nginx:alpine

# คัดลอกไฟล์เว็บไซต์
COPY src/ /usr/share/nginx/html

# เปิดพอร์ตตามที่กำหนดใน environment variable
EXPOSE 80

# คำสั่งเริ่มบริการ
CMD ["nginx", "-g", "daemon off;"]