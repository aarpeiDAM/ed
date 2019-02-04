package com.example.myapplication;

import android.content.Intent;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.*;
import android.widget.EditText;

import org.w3c.dom.Text;

public class MainActivity extends AppCompatActivity {
    public static final String KEY_MESSAGE="clave1";
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
    }
    public void sendMessage(View view){
        EditText editText =findViewById(R.id.editText);
        String message =editText.getText().toString();
        Intent intent = new Intent(this,DisplayMessageActivity.class);
        intent.putExtra(KEY_MESSAGE,message);
        startActivity(intent);

    }
}
