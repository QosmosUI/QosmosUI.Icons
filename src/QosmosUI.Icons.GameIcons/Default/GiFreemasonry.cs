// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons.Default;

public class GiFreemasonry : ComponentBase
{
    [Parameter]
    public string Title { get; set; } = string.Empty;

    [Parameter]
    public string Size { get; set; } = "1em";

    [Parameter]
    public string Stroke { get; set; } = "currentColor";

    [Parameter]
    public string Fill { get; set; } = "currentColor";

    [Parameter]
    public string StrokeWidth { get; set; } = "0";

    [Parameter]
    public string StrokeLinecap { get; set; } = "round";

    [Parameter]
    public string StrokeLinejoin { get; set; } = "round";

    [Parameter]
    public string ViewBox { get; set; } = "0 0 512 512";

    [Parameter(CaptureUnmatchedValues = true)]
    public IReadOnlyDictionary<string, object>? AdditionalAttributes { get; set; }

    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        builder.OpenElement(0, "svg");
        builder.AddAttribute(1, "xmlns", "http://www.w3.org/2000/svg");
        builder.AddAttribute(2, "viewBox", ViewBox);
        builder.AddAttribute(3, "width", Size);
        builder.AddAttribute(4, "height", Size);
        builder.AddAttribute(5, "fill", Fill);
        builder.AddAttribute(6, "stroke", Stroke);
        builder.AddAttribute(7, "stroke-width", StrokeWidth);
        builder.AddAttribute(8, "stroke-linecap", StrokeLinecap);
        builder.AddAttribute(9, "stroke-linejoin", StrokeLinejoin);
        builder.AddMultipleAttributes(10, AdditionalAttributes);
        if (!string.IsNullOrEmpty(Title))
        {
            builder.OpenElement(11, "title");
            builder.AddContent(12, Title);
            builder.CloseElement();
        }
		builder.OpenElement(13, "path");
		builder.AddAttribute(14, "d", "M256 25c-12.537 0-23 10.735-23 24.79 0 2.614.363 5.113 1.033 7.45l30.492-30.492C261.878 25.62 259 25 256 25zm21.043 14.684l-31.96 31.96c3.262 1.88 6.988 2.934 10.917 2.934 12.537 0 23-10.734 23-24.79 0-3.633-.703-7.043-1.957-10.104zm16.78 26.548C287.65 81.57 273.127 92.578 256 92.578c-1.528 0-3.033-.093-4.516-.264l231.92 386.536L293.822 66.232zm-77.09 3.147L28.595 478.85l216.908-361.516-28.772-47.955zM74.98 196.335L19.826 251.49l9.9 9.9 27.577-27.577 6.363-6.364 12.73 12.726-6.365 6.365-27.577 27.577 9.9 9.9 16.264-16.263 6.363-6.363 12.73 12.727-6.366 6.365-16.262 16.264 9.898 9.9 23.915-23.914 19.67-42.812-43.585-43.584zm362.04 0l-43.584 43.584 19.67 42.812 23.914 23.913 9.898-9.9-16.262-16.263-6.365-6.365 12.73-12.726 6.363 6.364 16.263 16.264 9.9-9.9-27.577-27.577-6.365-6.364 12.73-12.727 6.362 6.363 27.576 27.578 9.9-9.9-55.153-55.154zm-271.97 90.07l-31.013 51.692 13.775-13.776 6.364-6.363 12.728 12.726-6.363 6.365-27.575 27.58 9.898 9.897 16.264-16.263 6.363-6.364 12.73 12.727-6.366 6.365-16.264 16.262 9.9 9.9 27.578-27.576 6.364-6.365 12.728 12.728-6.365 6.365-27.576 27.578 9.897 9.898 16.264-16.262 6.366-6.364 12.727 12.73-6.364 6.362-16.264 16.264 9.9 9.9 27.576-27.578 6.364-6.363L256 419.78l11.314-11.31 6.364 6.362 27.576 27.578 9.9-9.9-16.263-16.264-6.363-6.363 12.727-12.73 6.365 6.365 16.263 16.263 9.898-9.897-27.575-27.578-6.365-6.364 12.728-12.727 6.364 6.365 27.578 27.576 9.9-9.9-16.264-16.262-6.365-6.365 12.73-12.727 6.363 6.364 16.264 16.263 9.898-9.898-27.576-27.58-6.364-6.364 12.728-12.727 6.363 6.362 13.776 13.774-31.014-51.69-90.95 90.95-90.95-90.95zM256 422.61l-4.95 4.95-27.577 27.577L256 487.664l32.527-32.527-27.578-27.576-4.95-4.95z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
