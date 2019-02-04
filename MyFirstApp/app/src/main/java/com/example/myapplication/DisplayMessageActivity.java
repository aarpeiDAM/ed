package com.example.myapplication;

import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.widget.TextView;
import android.content.Intent;
import org.w3c.dom.Text;

public class DisplayMessageActivity extends AppCompatActivity {
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_display_message);
        Intent intent =getIntent();
        String message = intent.getStringExtra(MainActivity.KEY_MESSAGE);
        TextView textView =findViewById(R.id.textView);
        textView.setText(message);

    }

}
