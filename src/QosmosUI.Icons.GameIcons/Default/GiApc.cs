// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons.Default;

public class GiApc : ComponentBase
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
		builder.AddAttribute(14, "d", "M96.962 289.6c23.244.038 43.825 15.022 51 37.13 7.175-22.1 27.766-37.064 51-37.064 23.235 0 43.826 14.965 51 37.064 7.175-22.1 27.766-37.064 51-37.064 23.235 0 43.826 14.965 51 37.064 8.08-24.967 33.042-40.42 58.992-36.515 25.95 3.904 45.262 26.016 45.638 52.255 12.316-8.64 22.722-33.47 26.31-50.18 2.25-4.978-.737-10.75-6.1-11.79l-42.28-14.16a9.24 9.24 0 0 1-3.83-1.71l-55.42-50a9.68 9.68 0 0 0-5.85-2h-261.37a16.132 16.132 0 0 0-10.51 3.9l-64.31 60.67a14 14 0 0 0-4.62 13.37L45.842 327c7.097-22.255 27.76-37.373 51.12-37.4zm206.78-59.6h58.81l24.5 21.62h-83.31zm49.21-60h-99v8.73h-39.9v16.92h-65.7v-16.92h-14.49v-32.58h26.31v-14h42.71v14h51.07v9h99zm-256 209.85a36.62 36.62 0 1 1 14.014-70.452 36.62 36.62 0 0 1 22.606 33.832c0 20.22-16.39 36.614-36.61 36.62zm102 0a36.62 36.62 0 1 1 14.014-70.452 36.62 36.62 0 0 1 22.606 33.832c0 20.186-16.334 36.565-36.52 36.62zm102 0a36.62 36.62 0 1 1 14.014-70.452 36.62 36.62 0 0 1 22.606 33.832c0 20.186-16.334 36.565-36.52 36.62zm102 0a36.62 36.62 0 1 1 14.014-70.452 36.62 36.62 0 0 1 22.606 33.832c0 20.186-16.334 36.565-36.52 36.62z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
