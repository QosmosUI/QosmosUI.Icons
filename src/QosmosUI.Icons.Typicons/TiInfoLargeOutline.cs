// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Typicons;

public class TiInfoLargeOutline : ComponentBase
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
		builder.AddAttribute(14, "d", "M14.234 16.014l.554-1.104c.808-1.61.897-3.228.253-4.552-.122-.252-.277-.479-.443-.693 1.411-.619 2.402-2.026 2.402-3.664 0-2.206-1.794-4-4-4s-4 1.794-4 4c0 .783.234 1.508.624 2.126-1.696.33-2.806 1.248-2.947 1.375-.716.631-.885 1.68-.405 2.504.324.559.886.909 1.494.98l-.554 1.104c-.808 1.61-.897 3.228-.254 4.552.565 1.164 1.621 1.955 2.972 2.229.413.084.836.127 1.254.127 2.368 0 3.965-1.347 4.14-1.501.716-.63.887-1.678.407-2.503-.325-.556-.887-.909-1.497-.98zm-1.234-12.013c1.104 0 2 .896 2 2s-.896 2-2 2c-1.105 0-2-.896-2-2s.895-2 2-2zm-1.816 14.999c-.271 0-.559-.025-.854-.087-1.642-.334-2.328-1.933-1.328-3.927l1-1.995c.5-.996.47-1.63-.108-2.035-.181-.125-.431-.169-.689-.169-.577 0-1.201.214-1.201.214s1.133-1.001 2.812-1.001c.271 0 .56.025.856.087 1.64.334 2.328 1.933 1.328 3.927l-1 1.993c-.5.998-.472 1.632.106 2.035.181.126.433.169.692.169.577 0 1.2-.212 1.2-.212s-1.133 1.001-2.814 1.001z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
