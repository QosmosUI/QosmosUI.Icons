// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons.Default;

public class GiSpikyEclipse : ComponentBase
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
		builder.AddAttribute(14, "d", "M159.182 17.115l14.882 129.483-46.134-25.303 37.46 72.914c18.642-27.004 49.798-44.702 85.094-44.702 57.07 0 103.334 46.262 103.334 103.332 0 30.772-13.454 58.398-34.797 77.328l67.918 29.404-26.258-60.27 137.83-15.784-126.504-44.65 81.853-53.58H360.1L465.104 18.735 334.8 125.76l-2.978-72.926-69.95 84.832-19.35-84.834-22.323 68.46L159.18 17.116zM24.94 141.8l48.62 54.354 71.725 25.797-51.588-58.237L24.94 141.8zM147.17 254.52l-49.526 27.513 43.69 4.684-76.457 95.18 90.5-48.372-82.702 160.72 124.83-127.95 6.242 71.775 26.863-83.812c-47.03-9.163-82.65-50.216-83.44-99.738zm155.935 87.263c-12.105 7.178-25.8 11.952-40.433 13.672l75.08 136.164-34.647-149.837zM249.95 373.95h-.003l-11.457 59.872 19.237 60.74 12.533-63.812-20.31-56.8zm131.48 13.45l34.513 48.39 52.453 12.493v-.002L435.8 403.183 381.43 387.4z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
