import {
  Button,
  Card,
  CardActions,
  CardContent,
  CardMedia,
  Typography,
} from "@mui/material";
import { LoadingButton } from "@mui/lab";

import { Link } from "react-router-dom";

import { Product } from "../../app/models/product";
import { currencyFormat } from "../../app/util/util";
import { useAppDispatch, useAppSelector } from "../../app/store/configureStore";
import { addBasketItemAsync } from "../basket/basketSlice";

interface Props {
  product: Product;
}

export default function ProductCard({ product }: Props) {
  const { status } = useAppSelector((state) => state.basket);
  const dispatch = useAppDispatch();

  return (
    <Card>
      <CardMedia
        component='img'
        height='250'
        image={product.pictureUrl}
        alt='product image'
      />
      <CardContent>
        <Typography gutterBottom variant='h5' component='div'>
          {product.name}
        </Typography>
        <Typography gutterBottom color='secondary' variant='h5' component='h5'>
          {currencyFormat(product.price)}
        </Typography>
        <Typography variant='body2' color='text.secondary'>
          {product.brand} / {product.type}
        </Typography>
      </CardContent>
      <CardActions>
        <LoadingButton
          loading={status.includes("pendingAddItem" + product.id)}
          onClick={() =>
            dispatch(addBasketItemAsync({ productId: product.id }))
          }
          size='small'
        >
          Add to Cart
        </LoadingButton>
        <Button component={Link} to={`/catalog/${product.id}`} size='small'>
          View
        </Button>
      </CardActions>
    </Card>
  );
}
