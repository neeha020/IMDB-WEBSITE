.coming-soon-section {
  background-color: #000;
  color: #fff;
  padding: 20px;
}

.coming-soon-section h2 {
  color: #facc15;
  font-size: 24px;
  margin-bottom: 5px;
}

.coming-soon-section p {
  color: #ccc;
  margin-bottom: 20px;
}

.carousel-wrapper {
  display: flex;
  align-items: center;
  position: relative;
}

.scroll-btn {
  background: rgba(255, 255, 255, 0.1);
  border: none;
  color: white;
  font-size: 24px;
  padding: 10px;
  cursor: pointer;
  border-radius: 5px;
}

.carousel {
  display: flex;
  gap: 20px;
  overflow-x: auto;
  scroll-behavior: smooth;
}

.movie-card {
  background-color: #111;
  border-radius: 12px;
  width: 300px;
  flex-shrink: 0;
  overflow: hidden;
}

.movie-thumbnail {
  position: relative;
  border-radius: 12px;
  overflow: hidden;
}

.movie-thumbnail video {
  width: 100%;
  height: auto;
  border-radius: 12px;
}

.duration {
  position: absolute;
  bottom: 8px;
  left: 8px;
  background: rgba(0, 0, 0, 0.7);
  color: #fff;
  padding: 2px 6px;
  border-radius: 4px;
  font-size: 14px;
}

.movie-info {
  padding: 10px 15px;
}

.release-date {
  color: #bbb;
  font-size: 14px;
  margin-bottom: 5px;
  font-weight: bold;
}

.title {
  font-size: 16px;
  font-weight: bold;
  margin-bottom: 5px;
}

.movie-info a {
  color: #3b82f6;
  text-decoration: none;
  font-size: 14px;
}

.reactions {
  margin-top: 10px;
  font-size: 14px;
  color: #aaa;
  display: flex;
  gap: 10px;
}


.scroll-btn {
  position: absolute;
  top: 45%;
  transform: translateY(-50%);
  font-size: 2rem;
  background: rgba(0, 0, 0, 0.5);
  color: white;
  border: none;
  padding: 5px 12px;
  cursor: pointer;
  z-index: 1;
  border-radius: 50%;
}

.scroll-btn.left {
  left: 0;
}

.scroll-btn.right {
  right: 0;
}

.highlight-bar {
  width: 5px;
  height: 24px;
  background-color: #f5c518;
  display: inline-block;
  margin-right: 10px;
  border-radius: 2px;
}
 #box {
      width: 200px;
      height: 150px;
      background-color: #4CAF50;
      color: white;
      display: flex;
      align-items: center;
      justify-content: center;
      margin: 20px 0;
      border-radius: 8px;
      font-size: 18px;
    }
    