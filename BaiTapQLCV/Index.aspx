<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="BaiTapQLCV.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
      <meta charset="utf-8">
      <meta content="width=device-width, initial-scale=1.0" name="viewport">
      <title>Bài tập Ví dụ 1</title>
      <meta name="description" content="Trang đăng nhập phần mềm ABC">
      <meta name="keywords" content="ABC, Phần mềm ..., ">

      <!-- Favicons -->
      <link href="/assets/img/user.png" rel="icon">
      <link href="/assets/img/user.png" rel="apple-touch-icon">

      <!-- Fonts -->
      <link href="https://fonts.googleapis.com" rel="preconnect">
      <link href="https://fonts.gstatic.com" rel="preconnect" crossorigin>
      <link href="https://fonts.googleapis.com/css2?family=Roboto:ital,wght@0,100;0,300;0,400;0,500;0,700;0,900;1,100;1,300;1,400;1,500;1,700;1,900&family=Lato:ital,wght@0,100;0,300;0,400;0,700;0,900;1,100;1,300;1,400;1,700;1,900&family=Poppins:ital,wght@0,100;0,200;0,300;0,400;0,500;0,600;0,700;0,800;0,900;1,100;1,200;1,300;1,400;1,500;1,600;1,700;1,800;1,900&display=swap" rel="stylesheet">

      <!-- Vendor CSS Files -->
      <link href="/assets/vendor/bootstrap/css/bootstrap.min.css" rel="stylesheet">
      <link href="/assets/vendor/bootstrap-icons/bootstrap-icons.css" rel="stylesheet">
      <link href="/assets/vendor/aos/aos.css" rel="stylesheet">
      <link href="/assets/vendor/glightbox/css/glightbox.min.css" rel="stylesheet">
      <link href="/assets/vendor/swiper/swiper-bundle.min.css" rel="stylesheet">

      <!-- Main CSS File -->
      <link href="/assets/css/main.css" rel="stylesheet">
</head>
<body>
    <form id="form1" runat="server">
        <header id="header" class="header d-flex align-items-center fixed-top">
            <div class="container position-relative d-flex align-items-center justify-content-between">

              <a href="index.html" class="logo d-flex align-items-center me-auto me-xl-0">
                <!-- Uncomment the line below if you also wish to use an image logo -->
                <!-- <img src="assets/img/logo.webp" alt=""> -->
                <h1 class="sitename">Creativo</h1>
              </a>

              <nav id="navmenu" class="navmenu">
                <ul>
                  <li><a href="#hero" class="active">Home</a></li>
                  <li><a href="#about">About</a></li>
                  <li><a href="#services">Services</a></li>
                  <li><a href="#portfolio">Portfolio</a></li>
                  <li><a href="#team">Team</a></li>
                  <li class="dropdown"><a href="#"><span>Dropdown</span> <i class="bi bi-chevron-down toggle-dropdown"></i></a>
                    <ul>
                      <li><a href="#">Dropdown 1</a></li>
                      <li class="dropdown"><a href="#"><span>Deep Dropdown</span> <i class="bi bi-chevron-down toggle-dropdown"></i></a>
                        <ul>
                          <li><a href="#">Deep Dropdown 1</a></li>
                          <li><a href="#">Deep Dropdown 2</a></li>
                          <li><a href="#">Deep Dropdown 3</a></li>
                          <li><a href="#">Deep Dropdown 4</a></li>
                          <li><a href="#">Deep Dropdown 5</a></li>
                        </ul>
                      </li>
                      <li><a href="#">Dropdown 2</a></li>
                      <li><a href="#">Dropdown 3</a></li>
                      <li><a href="#">Dropdown 4</a></li>
                    </ul>
                  </li>
                  <li><a href="#contact">Contact</a></li>
                </ul>
                <i class="mobile-nav-toggle d-xl-none bi bi-list"></i>
              </nav>

              <div class="header-social-links">
                <a href="#" class="twitter"><i class="bi bi-twitter-x"></i></a>
                <a href="#" class="facebook"><i class="bi bi-facebook"></i></a>
                <a href="#" class="instagram"><i class="bi bi-instagram"></i></a>
                <a href="#" class="linkedin"><i class="bi bi-linkedin"></i></a>
              </div>

            </div>
          </header>

        <main class="main">
            <section id="contact" class="contact section">
                <div class="container" >
                    <div class="row gy-5">
                      <div class="col-lg-8" >
                        <div class="main-contact-wrapper">
                            <div class="form-section">
                                    <div class="form-intro">
                                      <h3>Đăng nhập</h3>
                                      <p>Hãy đăng nhập để sử dụng các tính năng của phần mềm.</p>
                                    </div>

                                    <div class="php-email-form">
                                      <div class="row gy-3">
                                          <div class="col-md-8">
                                              <div class="input-group-custom">
                                                <i class="bi bi-envelope"></i>
                                                <asp:TextBox ID="tbEmail" TextMode="Email" class="form-control" placeholder="Địa chỉ email bạn đã dùng để đăng ký tài khoản" runat="server"></asp:TextBox>                                                
                                              </div>
                                            </div>
                                          <div class="col-md-8">
                                            <div class="input-group-custom">
                                              <i class="bi bi-key"></i>
                                              <asp:TextBox ID="tbPassword" TextMode="Password" class="form-control" placeholder="Mật khẩu đăng nhập tài khoản" runat="server"></asp:TextBox>                                                
                                            </div>
                                          </div>
                                          <div class="form-footer">
                                        <asp:Button ID="Button1" class="btn-submit" runat="server" Text="Đăng nhập" OnClick="Button1_Click" />                                        
                                      </div>
                                    </div>
                                </div>
                            </div>
                            </div>
                          </div>
                        </div>
                    </div>
                </section>
        </main>

        <footer id="footer" class="footer dark-background">
            <div class="container">
              <div class="row gy-5">

                <div class="col-lg-4">
                  <div class="footer-content">
                    <a href="index.html" class="logo d-flex align-items-center mb-4">
                      <span class="sitename">Creativo</span>
                    </a>
                    <p class="mb-4">Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae. Donec velit neque auctor sit amet aliquam vel ullamcorper sit amet ligula.</p>

                    <div class="newsletter-form">
                      <h5>Stay Updated</h5>
                      <form action="forms/newsletter.php" method="post" class="php-email-form">
                        <div class="input-group">
                          <input type="email" name="email" class="form-control" placeholder="Enter your email" required="">
                          <button type="submit" class="btn-subscribe">
                            <i class="bi bi-send"></i>
                          </button>
                        </div>
                        <div class="loading">Loading</div>
                        <div class="error-message"></div>
                        <div class="sent-message">Thank you for subscribing!</div>
                      </form>
                    </div>
                  </div>
                </div>

                <div class="col-lg-2 col-6">
                  <div class="footer-links">
                    <h4>Company</h4>
                    <ul>
                      <li><a href="#"><i class="bi bi-chevron-right"></i> About</a></li>
                      <li><a href="#"><i class="bi bi-chevron-right"></i> Careers</a></li>
                      <li><a href="#"><i class="bi bi-chevron-right"></i> Press</a></li>
                      <li><a href="#"><i class="bi bi-chevron-right"></i> Blog</a></li>
                      <li><a href="#"><i class="bi bi-chevron-right"></i> Contact</a></li>
                    </ul>
                  </div>
                </div>

                <div class="col-lg-2 col-6">
                  <div class="footer-links">
                    <h4>Solutions</h4>
                    <ul>
                      <li><a href="#"><i class="bi bi-chevron-right"></i> Digital Strategy</a></li>
                      <li><a href="#"><i class="bi bi-chevron-right"></i> Cloud Computing</a></li>
                      <li><a href="#"><i class="bi bi-chevron-right"></i> Data Analytics</a></li>
                      <li><a href="#"><i class="bi bi-chevron-right"></i> AI Solutions</a></li>
                      <li><a href="#"><i class="bi bi-chevron-right"></i> Cybersecurity</a></li>
                    </ul>
                  </div>
                </div>

                <div class="col-lg-4">
                  <div class="footer-contact">
                    <h4>Get in Touch</h4>
                    <div class="contact-item">
                      <div class="contact-icon">
                        <i class="bi bi-geo-alt"></i>
                      </div>
                      <div class="contact-info">
                        <p>2847 Maple Avenue<br>Los Angeles, CA 90210<br>United States</p>
                      </div>
                    </div>

                    <div class="contact-item">
                      <div class="contact-icon">
                        <i class="bi bi-telephone"></i>
                      </div>
                      <div class="contact-info">
                        <p>+1 (555) 987-6543</p>
                      </div>
                    </div>

                    <div class="contact-item">
                      <div class="contact-icon">
                        <i class="bi bi-envelope"></i>
                      </div>
                      <div class="contact-info">
                        <p>contact@example.com</p>
                      </div>
                    </div>

                    <div class="social-links">
                      <a href="#"><i class="bi bi-facebook"></i></a>
                      <a href="#"><i class="bi bi-twitter-x"></i></a>
                      <a href="#"><i class="bi bi-linkedin"></i></a>
                      <a href="#"><i class="bi bi-youtube"></i></a>
                      <a href="#"><i class="bi bi-github"></i></a>
                    </div>
                  </div>
                </div>

              </div>
            </div>

            <div class="footer-bottom">
              <div class="container">
                <div class="row align-items-center">
                  <div class="col-lg-6">
                    <div class="copyright">
                      <p>© <span>Copyright</span> <strong class="px-1 sitename">Creativo</strong> <span>All Rights Reserved</span></p>
                    </div>
                  </div>
                  <div class="col-lg-6">
                    <div class="footer-bottom-links">
                      <a href="#">Privacy Policy</a>
                      <a href="#">Terms of Service</a>
                      <a href="#">Cookie Policy</a>
                    </div>
                    <div class="credits">
                      <!-- All the links in the footer should remain intact. -->
                      <!-- You can delete the links only if you've purchased the pro version. -->
                      <!-- Licensing information: https://bootstrapmade.com/license/ -->
                      <!-- Purchase the pro version with working PHP/AJAX contact form: [buy-url] -->
                      Designed by <a href="https://bootstrapmade.com/">BootstrapMade</a> | <a href="https://bootstrapmade.com/tools/">DevTools</a>
                    </div>
                  </div>
                </div>
              </div>
            </div>

          </footer>
    </form>
</body>
</html>
