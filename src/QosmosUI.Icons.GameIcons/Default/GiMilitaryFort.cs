// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons.Default;

public class GiMilitaryFort : ComponentBase
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
		builder.AddAttribute(14, "d", "M256 21c-66.72 0-121 54.28-121 121s54.28 121 121 121 121-54.28 121-121S322.72 21 256 21zm0 18c56.992 0 103 46.008 103 103s-46.008 103-103 103-103-46.008-103-103S199.008 39 256 39zm0 11.75l-69.4 52.05 10.8 14.4L256 73.25l58.6 43.95 10.8-14.4L256 50.75zm0 48l-69.4 52.05 10.8 14.4 58.6-43.95 58.6 43.95 10.8-14.4L256 98.75zm0 48l-69.4 52.05 10.8 14.4 58.6-43.95 58.6 43.95 10.8-14.4-69.4-52.05zM53.562 185l-7 14h66.876l-7-14H53.562zm352 0l-7 14h66.875l-7-14h-52.875zM41 217v46h78v-46H41zm352 0v46h78v-46h-78zM64 231h32v18H64v-18zm352 0h32v18h-32v-18zM38.486 281l-10 30h455.028l-10-30H38.486zM25 329v158h199v-87h64v87h199V329H25zm55 14h32v18H80v-18zm80 0h32v18h-32v-18zm80 0h32v18h-32v-18zm80 0h32v18h-32v-18zm80 0h32v18h-32v-18z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
