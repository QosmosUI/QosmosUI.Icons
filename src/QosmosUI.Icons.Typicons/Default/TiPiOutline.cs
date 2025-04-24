// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Typicons.Default;

public class TiPiOutline : ComponentBase
{
    [Parameter]
    public string Title { get; set; } = string.Empty;

    [Parameter]
    public string Size { get; set; } = "24";

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
    public string ViewBox { get; set; } = "0 0 24 24";

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
		builder.AddAttribute(14, "d", "M20.121 7.121c-.566-.567-1.32-.879-2.121-.879s-1.555.312-2.121.879c-.233.233-.546.362-.879.362s-.646-.129-.879-.362c-1.366-1.366-3.185-2.118-5.121-2.118s-3.755.752-5.121 2.118c-.567.567-.879 1.32-.879 2.121s.312 1.555.879 2.121c.566.567 1.32.879 2.121.879v4.758c0 1.654 1.346 3 3 3s3-1.346 3-3c0 1.654 1.346 3 3 3s3-1.346 3-3v-4.166c.784-.356 1.501-.851 2.12-1.47.568-.567.88-1.321.88-2.122s-.312-1.554-.879-2.121zm-1.414 2.828c-.768.767-1.715 1.245-2.707 1.437v5.614c0 .553-.447 1-1 1s-1-.447-1-1v-5.614c-.992-.191-1.939-.67-2.707-1.437-.374-.374-.821-.623-1.293-.775v7.826c0 .553-.447 1-1 1s-1-.447-1-1v-7.827c-.473.152-.919.402-1.293.776-.195.196-.451.293-.707.293s-.512-.098-.707-.293c-.391-.391-.391-1.023 0-1.414 1.021-1.021 2.364-1.532 3.707-1.532s2.685.511 3.707 1.532c.633.632 1.463.948 2.293.948.831 0 1.661-.316 2.293-.948.195-.195.451-.293.707-.293s.512.098.707.293c.391.391.391 1.024 0 1.414z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
