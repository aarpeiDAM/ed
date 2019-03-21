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
    public TextView palabra;
    public TextView scoreText;
    public TextView fallosText;
    public int actualScore=0;
    public int fallos=0;

    Handler handler = new Handler();
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        palabra = findViewById(R.id.respuesta);
        scoreText = findViewById(R.id.score);
        fallosText = findViewById(R.id.fallos);
        ponerPalabrasEnBotones();
        scoreText.setText("Score: "+Integer.toString(actualScore));
        fallosText.setText("Fallos: "+Integer.toString(fallos));

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
        palabra.setText(listaPalabras.get(0));

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
            palabra.setText("Correcto");
            actualScore+=1;
            b.setTextSize(12);
            if(actualScore!=12){
                handler.postDelayed(new Runnable() {
                    @Override
                    public void run() {
                        actualizarScore();
                    }
                }, 2000);}
            else{
                scoreText.setText("Score: "+Integer.toString(actualScore));
                palabra.setText("Has ganado");
                handler.postDelayed(new Runnable() {
                    @Override
                    public void run() {
                        listaPalabras.clear();
                        actualScore=0;
                        fallos=0;
                        scoreText.setText("Score: "+Integer.toString(actualScore));
                        fallosText.setText("Fallos: "+Integer.toString(fallos));

                        ponerPalabrasEnBotones();
                    }
                }, 5000);

            }
        }else{
            fallos+=1;
            fallosText.setText("Fallos: "+Integer.toString(fallos));
        }
    }

    public void actualizarScore(){
        scoreText.setText("Score: "+Integer.toString(actualScore));
        listaPalabras.remove(0);
        palabra.setText(listaPalabras.get(0));
    }

}
