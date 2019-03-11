package com.example.apares2;

import android.os.Handler;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;

import java.util.ArrayList;
import java.util.Collections;
import java.util.List;
import java.util.Random;
import android.widget.TextView;

public class MainActivity extends AppCompatActivity {
    public List<String> listaPalabras= new ArrayList<String>();
    public TextView textView;
    public TextView textView2;
    public int actualScore=0;

    Handler handler = new Handler();
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        textView = findViewById(R.id.respuesta);
        textView2 = findViewById(R.id.score);
        ponerPalabrasEnBotones();
        textView2.setText("Score: "+Integer.toString(actualScore));

    }
    public int establecerRandom(int valor){
        Random rand = new Random();
        int random = rand.nextInt(valor);
        return random;
    }
    public void ponerPalabrasEnBotones(){
        listaPalabras.add("Leche");
        listaPalabras.add("Vaca");
        listaPalabras.add("Huevos");
        listaPalabras.add("Cerdos");
        listaPalabras.add("Pollos");
        listaPalabras.add("Conejos");
        listaPalabras.add("Cabras");
        listaPalabras.add("Ovejas");
        listaPalabras.add("Lana");
        listaPalabras.add("Cuero");
        listaPalabras.add("Trigo");
        listaPalabras.add("Zanahorias");

        Collections.shuffle(listaPalabras);

        for (int i = 1; i < 13; i++) {
            int id = getResources().getIdentifier("button"+i, "id", getPackageName());
            Button btn = findViewById(id);
            btn.setText(listaPalabras.get(i-1));
        }

        Collections.shuffle(listaPalabras);
        textView.setText(listaPalabras.get(0));

        handler.postDelayed(new Runnable() {
            @Override
            public void run() {
                for (int i = 1; i < 13; i++) {
                    int id = getResources().getIdentifier("button"+i, "id", getPackageName());
                    Button btn = findViewById(id);
                    btn.setTextSize(0);
                }
            }
        }, 5000);



    }
    public void comprobar(View view){
        Button b = (Button)view;
        if(b.getText()==listaPalabras.get(0)){
            textView.setText("Correcto");
            actualScore+=1;
            if(actualScore!=12){
                Handler handler = new Handler();
                handler.postDelayed(new Runnable() {
                    @Override
                    public void run() {
                        actualizarScore();
                    }
                }, 2000);}
            else{
                textView2.setText("Score: "+Integer.toString(actualScore));
                textView.setText("Has ganado");
                Handler handler = new Handler();
                handler.postDelayed(new Runnable() {
                    @Override
                    public void run() {
                        listaPalabras.clear();
                        actualScore=0;
                        textView2.setText("Score: "+Integer.toString(actualScore));
                        ponerPalabrasEnBotones();
                    }
                }, 5000);

            }
        }
    }

    public void actualizarScore(){
        textView2.setText("Score: "+Integer.toString(actualScore));
        cambiarTarget();
        textView.setText(listaPalabras.get(0));

    }
    public void cambiarTarget(){
        listaPalabras.remove(0);

    }
}
