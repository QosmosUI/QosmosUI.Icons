// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons.Default;

public class GiLightFighter : ComponentBase
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
		builder.AddAttribute(14, "d", "M215.078 20.037L100.754 135.693l52.133 79.313L21 491.963 296.824 359.53l79.42 52.784L491 297.088 215.078 20.038zm102.037 21.885l-21.082 21.174 16.865 16.933 21.088-21.17-16.87-16.938zm130.71 4.252l-84.32 84.666 16.862 16.94 84.328-84.667-16.87-16.94zm-75.893 8.463l-42.157 42.336 16.864 16.933 42.165-42.334-16.873-16.935zm67.463 67.744l-42.155 42.33 16.862 16.938 42.164-42.334-16.87-16.933zm12.658 55.038l-21.08 21.17 16.863 16.933 21.088-21.166-16.87-16.936zm-206.526 66.865c6.308.15 11.87 2.175 15.924 6.244 11.794 11.843 6.35 36.51-12.16 55.098-18.51 18.585-43.08 24.056-54.872 12.22-11.793-11.847-6.345-36.517 12.168-55.1 12.146-12.2 26.9-18.747 38.94-18.462z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
