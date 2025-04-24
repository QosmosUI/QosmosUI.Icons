// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons.Default;

public class GiEyeTarget : ComponentBase
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
		builder.AddAttribute(14, "d", "M256 105c-60.25 0-124.749 38.39-167.945 77.66-34.931 31.756-58.722 62.36-66.88 73.34 8.158 10.98 31.949 41.584 66.88 73.34C131.25 368.61 195.75 407 256 407s124.749-38.39 167.945-77.66c34.931-31.756 58.722-62.36 66.88-73.34-8.158-10.98-31.949-41.584-66.88-73.34C380.75 143.39 316.25 105 256 105zm0 23a128 128 0 0 1 63.486 16.969A48 48 0 0 0 288 190a48 48 0 0 0 .023.453A72.362 72.362 0 0 0 265 183.576V160h-18v23.576c-33.034 4.095-59.33 30.39-63.424 63.424H160v18h23.576c4.095 33.034 30.39 59.33 63.424 63.424V352h18v-23.576c33.034-4.095 59.33-30.39 63.424-63.424H352v-18h-23.576a72.33 72.33 0 0 0-1.98-10.014A48 48 0 0 0 336 238a48 48 0 0 0 41.023-23.195A128 128 0 0 1 384 256a128 128 0 0 1-128 128 128 128 0 0 1-128-128 128 128 0 0 1 128-128zm-9 73.738V224h18v-22.262c23.237 3.792 41.47 22.025 45.262 45.262H288v18h22.262c-3.792 23.237-22.025 41.47-45.262 45.262V288h-18v22.262c-23.237-3.792-41.47-22.025-45.262-45.262H224v-18h-22.262c3.792-23.237 22.025-41.47 45.262-45.262z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
