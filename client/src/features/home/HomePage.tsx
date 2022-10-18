import { Box, Typography } from "@mui/material";
import Slider from "react-slick";

export default function HomePage() {
  const settings = {
    dots: true,
    infinite: true,
    speed: 500,
    slidesToShow: 1,
    slidesToScroll: 1,
    centerMode: true,
  };

  return (
    <>
      <Slider {...settings}>
        <div>
          <img
            src='https://i.ibb.co/px2tCc3/jackets.png'
            alt='hero'
            style={{ display: "block", width: "75%", maxHeight: 500 }}
          />
        </div>
        <div>
          <img
            src='https://i.ibb.co/0jqHpnp/sneakers.png'
            alt='hero'
            style={{ display: "block", width: "75%", maxHeight: 500 }}
          />
        </div>
        <div>
          <img
            src='https://i.ibb.co/GCCdy8t/womens.png'
            alt='hero'
            style={{ display: "block", width: "75%", maxHeight: 500 }}
          />
        </div>
        <div>
          <img
            src='https://i.ibb.co/R70vBrQ/men.png'
            alt='hero'
            style={{ display: "block", width: "75%", maxHeight: 500 }}
          />
        </div>
      </Slider>

      <Box display='flex' justifyContent='center' sx={{ p: 4 }}>
        <Typography variant='h1'>Welcome to the shop!</Typography>
      </Box>
    </>
  );
}
