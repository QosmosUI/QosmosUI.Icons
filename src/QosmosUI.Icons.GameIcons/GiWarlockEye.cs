// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons;

public class GiWarlockEye : ComponentBase
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
		builder.AddAttribute(14, "d", "M256 16l-32 112 32 32 32-32-32-112zM64 96l32 80 64 16-96-96zm384 0l-96 96 64-16 32-80zm-192 80l-64 48-128 32c80 16 128 96 192 128 64-32 112.476-110.213 192-128l-128-28.31L256 176zm-39.512 52.682l28.342 8.863-7.45 20.955L256 310.895l18.62-52.395-7.45-20.955 28.342-8.863c14.923 10.97 24.488 28.03 24.488 47.283C320 309.237 291.47 336 256 336s-64-26.763-64-60.035c0-19.254 9.565-36.314 24.488-47.283zM96 336l-64 48-16 64 32-32 64-48s-16-27.61-16-32zm320 0l-16 32 64 48 32 32-16-64-64-48zm-272 64l-16 64 48-48-32-16zm112 0l-48 16 48 80 48-80-48-16zm112 0l-32 16 48 48-16-64z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
