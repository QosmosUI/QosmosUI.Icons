// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons.Default;

public class GiNinjaMask : ComponentBase
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
		builder.AddAttribute(14, "d", "M255.063 21c-46.697 0-88.406 27.674-117.844 70.656-29.44 42.982-47.25 101.566-47.25 166.094 0 64.527 17.81 123.112 47.25 166.094 29.437 42.982 71.146 70.656 117.843 70.656 46.696 0 88.405-27.674 117.843-70.656 29.44-42.982 47.25-101.567 47.25-166.094 0-64.528-17.81-123.112-47.25-166.094C343.468 48.674 301.76 21 255.062 21zM396.28 200.344c3.365 18.28 5.19 37.527 5.19 57.406 0 18.535-1.594 36.522-4.533 53.688-37.91 12.904-87.436 20.812-141.656 20.812-54.45 0-104.125-8.235-142.186-21.313-2.884-17.014-4.438-34.833-4.438-53.187 0-19.868 1.827-39.103 5.188-57.375 37.903 14.565 87.35 23.25 141.47 23.25 54.136 0 103.183-8.707 140.967-23.28zM177.157 241c-15.137-.162-30.97 3.458-47.375 10.313 14.562 51.423 87.08 42.483 102.157 10.156-17.004-13.822-35.318-20.262-54.78-20.47zm155.75 0c-19.462.208-37.808 6.648-54.812 20.47 15.078 32.326 87.596 41.266 102.156-10.158-16.405-6.854-32.206-10.474-47.344-10.312z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
